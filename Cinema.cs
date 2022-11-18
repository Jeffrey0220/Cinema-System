using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CinemaSystem
{
    class Cinema
    {

        public int Seats { get; set; }
        public DateTime TimeTable { get; set; }

        public Cinema()
        {
            TimeTable = new DateTime(2021, 11, 20, 20, 30, 0);
        }

      

    }
}
