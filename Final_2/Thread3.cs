using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
//Load via TextReader
namespace Final_2
{
    class Thread3
        
    {
        

        public static void textReaderXml()
        {
            string filename = @"..\..\BookCatalog.xml";

            Stopwatch sw = new Stopwatch();
            sw.Start();
           
            TextReader reader = new StreamReader(filename);
            XElement root = XElement.Load(filename);
            root = XElement.Load(reader);
            // write out the xml
            //Console.WriteLine(root);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Elapsed time for Thread 3 (load via textReader): " + "\t" + elapsedTime);
           
        }
    }
}
