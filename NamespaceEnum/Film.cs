using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceEnum
{
    class Film
    {
        Producer producer;
        string title;
        double cash;
        DateTime date;
        Dictionary.Genre genre;
        

        public string Title { get => title; set => title = (value != "") ? value : "Unnamed"; }
        public double Cash { get => cash; set => cash = (value > 0) ? value : 1; }
        public DateTime Date { get => date; set => date = (value < DateTime.Today)? value : DateTime.Today; }
        internal Producer Producer { get => producer; set => producer = value; }
        internal Dictionary.Genre Genre { get => genre; set => genre = value; }

        public Film(string title, double cash, DateTime date, Producer producer, Dictionary.Genre genre)
        {
            Title = title;
            Cash = cash;
            Date = date;
            Producer = producer;
            Genre = genre;
        }
        public Film()
        {
                
        }

        public override string ToString()
        {
            return $"Title: {title}\nDate: {date.ToShortDateString()}\nCash: {cash}\nProducer: {producer}\nGenre: {genre}";
        }
    }
}
