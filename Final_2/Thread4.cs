using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;

//Load via XML reader
namespace Final_2
{
    class Thread4
    {
        

        public static void readerXml()
        {
            string filename = @"..\..\BookCatalog.xml";

            Stopwatch sw = new Stopwatch();
            sw.Start(); 
          
            XElement root = XElement.Load(filename);
            XmlReader xmlreader = new XmlTextReader(new StreamReader(filename));
            root = XElement.Load(xmlreader);
            // write out the xml
            //Console.WriteLine(root);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Elapsed time for Thread 4 (load via xmlReader): " + "\t" + elapsedTime);
        }
    }
}
