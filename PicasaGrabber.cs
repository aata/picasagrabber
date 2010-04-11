using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace PicasaGrabber
{
    class Grabber
    {
        public static void grabberMain(string url,string path)
        {
            WebRequest request = WebRequest.Create(url);//"http://picasaweb.google.fr/data/feed/base/user/guillaume.bittoun/albumid/5358370501715750369?alt=rss&kind=photo&authkey=Gv1sRgCKi895mA4r_jpgE&hl=fr");

            System.Net.WebResponse myResponse;
            myResponse = request.GetResponse();
            System.IO.Stream myStream = myResponse.GetResponseStream();
            System.IO.StreamReader streamRead = new System.IO.StreamReader(myStream);

            string completeFile = streamRead.ReadToEnd();

            completeFile = completeFile.Replace("/>", "/>\r\n");
            completeFile = completeFile.Replace("<enclosure", "\r\n<enclosure");

            string[] lines = completeFile.Split(new char[] { '\n' });

            System.IO.File.AppendAllText("c:\\pouet.txt", completeFile);

            foreach (string s in lines)
            {
                if (s.Contains("<enclosure"))
                {
                    //Regex express = new Regex("(([a-zA-Z][0-9a-zA-Z+\\-\\.]*:)?/{0,2}[0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?(#[0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?");
                    Regex express = new Regex("http://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?(JPG|jpg)");
                    Match m = express.Match(s);

                    string[] elements = m.ToString().Split('/');

                    System.Net.WebRequest imageRequest = WebRequest.Create(m.ToString());
                    System.Net.WebResponse imageResponse;
                    imageResponse = imageRequest.GetResponse();
                    System.IO.Stream imgStream = imageResponse.GetResponseStream();
                    //System.IO.StreamReader imgStreamRead = new System.IO.StreamReader(imgStream);
                    byte[] img = new byte[1024];
                    System.IO.Stream fileStream = System.IO.File.Create(path + "\\" + elements[elements.Length-1]);
                    int nbBytes;

                    while ((nbBytes = imgStream.Read(img, 0, 1024)) > 0)
                    {
                        fileStream.Write(img, 0, nbBytes);
                    }
                    fileStream.Close();
                }
            }

            Console.ReadKey(true);
        }
    }
}
