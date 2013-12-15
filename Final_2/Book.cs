using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_2
{
    public class Book
    {
        [XmlElement("ISBN")]
        public int Isbn;
        [XmlElement("year")]
        public int Year;

        [XmlElement("title")]
        public string Title;

        [XmlElement("publisher")]
        public string Publisher;

        [XmlElement("price")]
        public decimal Price;


        public Book()
        {
            // Default constructor for serialization.
        }

        public Book(int isbn, int year, string title, string publisher, decimal price)
        {

            this.Isbn = isbn;
            this.Year = year;
            this.Title = title;
            this.Price = price;
            this.Publisher = publisher;

        }
    }
}
