using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CinemaSystem
{
    class MoviePlayQueue
    {
        private MovieQueueNode FrontNode;
        public static int counter3;//for testing

        public MovieQueueNode FRONTNODE
        {
            get { return FrontNode; }
            set { FrontNode = value; }
        }
        //add a movie to the end of the queue
        public void Enqueue(Movie x)
        {
            if (FrontNode == null)
            {
                FrontNode = new MovieQueueNode(x);
            }
            else
            {
                FrontNode.Enqueue(x);
            }
        }
        //delete and return a movie from the front of the queue
        public Movie Dequeue()
        {
            MovieQueueNode temp = FrontNode;
            counter3=1;//for testing
            if (temp == null)
            {
                WriteLine("Stack is empty");
                return null;
            }
            else
            {
                FrontNode = temp.NEXT;
                counter3++;
                return temp.AMOVIE;                
            }
        }
        //display all the movies in this queue
        public void Display()
        {
            MovieQueueNode temp = FrontNode;
            if (temp == null)
            {
                WriteLine("Movie play list is empty");
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
    }
}
