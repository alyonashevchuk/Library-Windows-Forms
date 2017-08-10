using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string Publish { get; set; }
        public string Descrip { get; set; }
        public string address;
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 2016) throw new Exception("Not correct date!");
                year = value;
            }
        }
        public Book()
        {
            Title = "<No title>";
            Author = "<No author>";
            Subject = "<No subject>";
            Publish = "<No publishing house>";
            Descrip = "";
            Year = DateTime.Now.Year;
        }
        public Book(string name, string ven, string sub, string publish, string descrip, int y)
        {
            Title = name;
            Author = ven;
            Subject = sub;
            Publish = publish;
            Descrip = descrip;
            Year = y;
        }
        public override string ToString()
        {
            return Title + ", автор " + Author + ", рік " + Year + " р.";
        }
    }
}
