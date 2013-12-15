using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;

//Load XML using the filename
namespace Final_2
{
    class Thread1
    {
        

        public Thread1() { }

        // load the XML using the file name

        public static void fileNameXml()
        {
            string filename = @"..\..\BookCatalog.xml";

            Stopwatch sw = new Stopwatch();
            sw.Start();

            XElement root = XElement.Load(filename);
            // write out the xml
            //Console.WriteLine(root);           
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Elapsed time for Thread 1 (load via filename): " + "\t" + "\t" + elapsedTime);
        }
    }
}