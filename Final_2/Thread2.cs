using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
//Load via stream to file
namespace Final_2
{
    class Thread2
    {
         

        public Thread2() { }

        public static void streamXml()
        {
            string filename = @"..\..\BookCatalog.xml";

            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            FileStream filestream = File.OpenRead(filename);
            XElement root = XElement.Load(filename);
            root = XElement.Load(filestream);
            // write out the xml
            //Console.WriteLine(root);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Elapsed time for Thread 2 (load via stream to file): " + "\t" + elapsedTime);
        }        
    }
}
