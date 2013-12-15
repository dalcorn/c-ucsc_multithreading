using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_2
{

    [XmlRoot("bookstore")]
    public class BookCatalog
    {

        [XmlArray("books")]
        [XmlArrayItem("book")]
        public Book[] books;   //Books

        public BookCatalog()
        {
            // Default constructor for deserialization.
        }

    }
}
