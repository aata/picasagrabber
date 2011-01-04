using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace PicasaGrabber
{
    class Grabber
    {
        private static Dictionary<Guid, Grabber> _instanceIds = new Dictionary<Guid, Grabber>();

        public static Dictionary<Guid, Grabber> InstanceIds { get { return _instanceIds; } }

        string url = string.Empty;
        string path = string.Empty;
        Guid id;

        object aborting = new object();
        bool abort = false;

        public void Abort()
        {
            lock(aborting)
                abort = true;
        }

        public Grabber(Guid _id, string _url , string _path)
        {
            id = _id;
            url = _url;
            path = _path;

            _instanceIds.Add(id, this);
        }

        private int min = 0, max = 100, val = 0;

        public void GetDownloadState(out int _min, out int _max, out int _val)
        {
            _min = min;
            _max = max;
            _val = val;
        }

        public void grabberMain()
        {
            WebRequest request = WebRequest.Create(url);

            System.Net.WebResponse myResponse;
            myResponse = request.GetResponse();
            System.IO.Stream myStream = myResponse.GetResponseStream();
            System.IO.StreamReader streamRead = new System.IO.StreamReader(myStream);

            string completeFile = streamRead.ReadToEnd();

            completeFile = completeFile.Replace("/>", "/>\r\n");
            completeFile = completeFile.Replace("<enclosure", "\r\n<enclosure");

            string[] lines = completeFile.Split(new char[] { '\n' });

            this.val = this.min = 0;
            this.max = lines.Length;

            foreach (string s in lines)
            {
                if (s.Contains("<enclosure"))
                {
                    Regex express = new Regex("http://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?(JPG|jpg)");
                    Match m = express.Match(s);

                    string[] elements = m.ToString().Split('/');

                    System.Net.WebRequest imageRequest = WebRequest.Create(m.ToString());
                    System.Net.WebResponse imageResponse;
                    imageResponse = imageRequest.GetResponse();
                    System.IO.Stream imgStream = imageResponse.GetResponseStream();
                    byte[] img = new byte[1024];
                    System.IO.Stream fileStream = System.IO.File.Create(path + "\\" + elements[elements.Length - 1]);

                    int nbBytes;

                    while ((nbBytes = imgStream.Read(img, 0, 1024)) > 0)
                        fileStream.Write(img, 0, nbBytes);

                    fileStream.Close();
                }
                this.val++;

                if (abort)
                    break;
            }

            _instanceIds.Remove(this.id);
        }
    }
}
