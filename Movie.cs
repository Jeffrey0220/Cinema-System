using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    class Movie
    {
        private string MName;
        private double Price;
        private DateTime RecieveDate;

        public string MNAME
        {
            get { return MName; }
            set { MName = value; }
        }

        public double PRICE
        {
            get { return Price; }
            set { Price = value; }
        }

        public DateTime RECIEVEDATE
        {
            get { return RecieveDate; }
            set { RecieveDate = value; }
        }
        
        public Movie(string MNAME, double PRICE,DateTime RECIEVEDATE)
        {
            MName = MNAME;
            Price = PRICE;
            RecieveDate = RECIEVEDATE;
        }
        //present movies' information
        public override string ToString()
        {
            return $"Movie info==> Movie name: {MName}; Price: ${Price}; Receive Date: {RecieveDate.ToShortDateString()}";
        }
    }
}
