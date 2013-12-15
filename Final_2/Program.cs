using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Final_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the book catalog.
            BookCatalog catalog = new BookCatalog();

            Book[] books = new Book[10000];
            Random r = new Random();

            //use hashset to ensure random number is unique
            HashSet<int> hashset = new HashSet<int>();

            for (int i = 0; i < books.Length; i++)
            {
                
                int Isbn = r.Next(00000001, 99999999);
                if (!hashset.Contains(Isbn))
                {
                    books[i] = new Book(Isbn, 2001, "Terrible Book", "abc publishing", 202.99m);
                    hashset.Add(Isbn);
                }
                else
                {                   
                    continue;
                }               
            }
            catalog.books = books;
           
            // Serialize the order to a file.
            XmlSerializer serializer = new XmlSerializer(typeof(BookCatalog));
            FileStream fs = new FileStream("BookCatalog.xml", FileMode.Create);
            serializer.Serialize(fs, catalog);
            fs.Close();          

            //streamwriter
            System.IO.StreamWriter file = new System.IO.StreamWriter(
                @"..\..\BookCatalog.xml");
            serializer.Serialize(file, catalog);
            file.Close();

            Console.WriteLine("\nBookCatalog.xml was created.  File contains {0} books.", books.Length);
            Console.WriteLine("\nFile loaded four different ways by four threads: ");
            Console.WriteLine("");
            
            
            //start all four threads
            Thread t1 = new Thread(Thread1.fileNameXml);
            t1.Start();
            Thread t2 = new Thread(Thread2.streamXml);
            t2.Start();
            Thread t3 = new Thread(Thread3.textReaderXml);
            t3.Start();
            Thread t4 = new Thread(Thread4.readerXml);
            t4.Start();

            Console.ReadKey();
        }
    }
}

