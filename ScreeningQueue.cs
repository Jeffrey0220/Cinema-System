using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CinemaSystem
{
    class ScreeningQueue
    {
        private ScreeningQueueNode FrontNode;
        private Movie ChosenMovie;
        public static int counter;//fot test
        public static int counter9;//for test

        public Movie CHOSENMOVIE
        {
            get { return ChosenMovie; }
            set { ChosenMovie = value; }
        }

        public ScreeningQueueNode FRONTNODE
        {
            get { return FrontNode; }
            set { FrontNode = value; }
        }

        public void Enqueue(Movie x)
        {
            if (FrontNode == null)
            {
                FrontNode = new ScreeningQueueNode(x);
            }
            else
            {
                FrontNode.Enqueue(x);
            }
        }

        public Movie ScheduleScreening(MovieStack x, MoviePlayQueue y)
        {
            Movie z = ChoosingNextMovie(x, y);
            counter = 0;//fot test
            for (int i = 1; i <= 3; i++)
            {
                Enqueue(z);
                counter++;//fot test
            }
            return z;
        }

        public Movie Dequeue()
        {
            ScreeningQueueNode temp = FrontNode;
            counter9 = 0;
            if(IsEmpty())
            {
                WriteLine("Schedule is empty, please next movie.");
                return null;
            }
            if (temp.NEXT == null)
            {
                FrontNode = null;
                counter9++;//for test
                return temp.AMOVIE;
            }
            else
            {
                FrontNode = temp.NEXT;
                counter9++;//for test
                return temp.AMOVIE;
            }

        }

        Cinema TheCinema = new Cinema();

        public Movie NextScreening(MovieStack x, MoviePlayQueue y)
        {

            TheCinema.Seats = 7;
            TheCinema.TimeTable = TheCinema.TimeTable.AddHours(12);
            counter = 0;//fot test

            if (IsEmpty())
            {
                ScheduleScreening(x, y);
                ChosenMovie = Dequeue();
                return ChosenMovie;
            }
            else
            {
                ChosenMovie = Dequeue();
                return ChosenMovie;
            }                      
        }

        public Movie ChoosingNextMovie(MovieStack x, MoviePlayQueue y)
        {

            if (!x.IsEmpty())
            {
                CHOSENMOVIE = x.Pop();
                y.Enqueue(CHOSENMOVIE);
                return CHOSENMOVIE;
            }
            else
            {
                CHOSENMOVIE = y.Dequeue();
                y.Enqueue(CHOSENMOVIE);
                return CHOSENMOVIE;
            }
        }

        public bool IsEmpty()
        {
            ScreeningQueueNode temp = FrontNode;
            if (temp == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Display()
        {
            ScreeningQueueNode temp = FrontNode;
            if (temp == null)
            {
                WriteLine("Screening schedule is empty, please choose a movie.");
            }
            else
            {
                while (temp != null)
                {

                    WriteLine(temp.AMOVIE.ToString());
                    temp = temp.NEXT;
                } 
            }
        }

        public void SellTicket(Movie x)
        {
            Console.WriteLine($"Avaliable Ticket: Movie Name: {x.MNAME}, Price: ${x.PRICE}, Screening Time: {TheCinema.TimeTable}, Remaining ticket:{TheCinema.Seats}.");
        }

        public void Booking(Movie x, Customer c)
        {

            if (TheCinema.Seats > 0)
            {
                if (c.FREETICKET)
                {
                    WriteLine($"{x.MNAME} => Booking successfully");
                    WriteLine(c.ToString());
                }
                else
                {
                    WriteLine($"{x.MNAME} => Booking successfully");
                    c.TICKETCOUNT = c.TICKETCOUNT + 1;
                    WriteLine(c.ToString());
                }
                TheCinema.Seats--;
            }
            else
            {
                WriteLine("Sorry, tickets are sold out.");
                WriteLine(c.ToString());
            }
        }
    }
}
