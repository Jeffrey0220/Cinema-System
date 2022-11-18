using System;
using static System.Console;

namespace CinemaSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //**************************//
            //*** FUNCTIONAL TESTING ***//  !!!( WHEN YOU DO FUCNTIONAL TESTING, PLEASE COMMENT OUT EFFICIENCY TESTING PART, VICE VERSA )
            //**************************//


            //Use Linked List structure make a Cinema Customer List to add and delete customer infomation.(Implement with clsses: Customer, CustomerList and CListNode)
            CustomerList CinemaCustomerList = new CustomerList();

            //Customers
            Customer Micheal = new Customer("Michael", "Scott", "0434123456", "PayPal Pay");          
            Customer Dwight = new Customer("Dwight", "Schrute", "0434123457", "Apple Wallet");           
            Customer Jim=new Customer("Jim", "Halpert", "0434123455","Credit Card");          
            Customer Pam = new Customer("Pam", "Beesly", "0434123459", "PayPal Pay");            
            Customer Angela = new Customer("Angela", "Martin", "0434123450", "Credit Card");         
            Customer Kevin= new Customer("Kevin", "Malone", "0434123451", "Apple Wallet");        
            Customer Phyllis = new Customer("Phyllis", "Vance", "0434123466", "PayPal Pay");


            //Adding customers into Cinema Customer List
            WriteLine("Adding 6 customers into Cinema Customer List:");
            CinemaCustomerList.Adding(Micheal);         
            CinemaCustomerList.Adding(Jim);            
            CinemaCustomerList.Adding(Pam);
            CinemaCustomerList.Adding(Dwight);
            CinemaCustomerList.Adding(Angela);
            CinemaCustomerList.Adding(Kevin);


               //Display the customer list and count the number of customer
               WriteLine("\nDisplay the customer list and count the number of customer:");
               CinemaCustomerList.Display();
               CinemaCustomerList.CountNum();


               //Removing a customer from Cinema Customer List
               WriteLine("\nRemoving Dwight and Angela from Cinema Customer List");
               CinemaCustomerList.Removing(Dwight);
               CinemaCustomerList.Removing(Angela);


               //Display the customer list and count the number of customer
               WriteLine("\nDisplay the customer list and count the number of customer:");
               CinemaCustomerList.Display();
               CinemaCustomerList.CountNum();

               //Adding customers into Cinema Customer List
               WriteLine("\nAdding Phyllis into Cinema Customer List:");
               CinemaCustomerList.Adding(Phyllis);
               //Display the customer list and count the number of customer
               WriteLine("\nDisplay the customer list and count the number of customer:");
               CinemaCustomerList.Display();
               CinemaCustomerList.CountNum();
               WriteLine(" ");



               //Use stack structure make Cinema Movies for receiving a new movie.(Implement with classes: Movie, MovieStack, MovieStackNode)
               MovieStack CinemaMovies = new MovieStack();

               //Receiving three movies.
               CinemaMovies.ReceivingAMovie(new Movie("The Matrix",22.50,new DateTime(2015,12,11)));
               CinemaMovies.ReceivingAMovie(new Movie("Spider-Man", 20.00, new DateTime(2017, 06, 01)));
               CinemaMovies.ReceivingAMovie(new Movie("Fight Club", 20.50, new DateTime(2017, 12, 19)));
               //Disply all the received movies.
               WriteLine("Receiving three movies. Display all the movies:");
               CinemaMovies.Display();
               WriteLine(" ");

               //Receiving another two movies.
               CinemaMovies.ReceivingAMovie(new Movie("Tenet", 22.00, new DateTime(2019, 10, 10)));
               CinemaMovies.ReceivingAMovie(new Movie("Avengers:Endgame", 23.00, new DateTime(2020, 01, 17)));
               //Disply all the received movies.
               WriteLine("Recieving another two movies, Display all the movies:");
               CinemaMovies.Display();


               //Use queue strectures make a Movie Play List and Screenings, combine with stack structure Cinema Movies to choose next movie .
               //(Implement with classes: Movie, MovieStack, MovieStackNode, MoviePlayQueue, Movie, ScreeningQueue, ScreeningQueueNode)
               MoviePlayQueue MoviePlayList = new MoviePlayQueue();
               ScreeningQueue screenings = new ScreeningQueue();
               WriteLine(" ");

               //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
              WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
              WriteLine(" ");
              WriteLine("Cinema Movies:");
              CinemaMovies.Display();
              WriteLine("**************************************************************************");           
              WriteLine("Movie Play List:");
              MoviePlayList.Display();
              WriteLine(" ");


             WriteLine("Using NextScreening() to schedule next screen ");
             WriteLine(screenings.NextScreening(CinemaMovies,MoviePlayList).MNAME);
             WriteLine(" ");

             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");

             WriteLine("Using NextScreening() to schedule next screen ");
             WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
             WriteLine(" ");

             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");

             WriteLine("Using NextScreening() to schedule next screen ");
             WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
             WriteLine(" ");

             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");

             WriteLine("Using NextScreening() to schedule next screen ");
             WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
             WriteLine(" ");

             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Jim);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Pam);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");


             WriteLine("Using NextScreening() to schedule next screen ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");
             screenings.Booking(screenings.CHOSENMOVIE, Micheal);
             WriteLine(" ");
             screenings.SellTicket(screenings.CHOSENMOVIE);
             WriteLine(" ");




             /*WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");
              WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");

              //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
              WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
              WriteLine(" ");
              WriteLine("Cinema Movies:");
              CinemaMovies.Display();
              WriteLine("**************************************************************************");
              WriteLine("Movie Play List:");
              MoviePlayList.Display();
              WriteLine(" ");

              WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");
              WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");
              WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");

              //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
              WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
              WriteLine(" ");
              WriteLine("Cinema Movies:");
              CinemaMovies.Display();
              WriteLine("**************************************************************************");
              WriteLine("Movie Play List:");
              MoviePlayList.Display();
              WriteLine(" ");


              WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");
              WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");
              WriteLine("Using NextScreening() to schedule next screen ");
              WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");

              /*WriteLine("Afrer using scheduleScreening() it automatically choose a movie use ChoosingNextMovie() " +
                  "\nto make a 3 screenings for the chosen movie ");
              WriteLine(screenings.ScheduleScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");

              //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
              WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
              WriteLine(" ");
              WriteLine("Cinema Movies:");
              CinemaMovies.Display();
              WriteLine("**************************************************************************");
              WriteLine("Movie Play List:");
              MoviePlayList.Display();
              WriteLine(" ");

              WriteLine("Afrer using scheduleScreening() it automatically choose a movie use ChoosingNextMovie() " +
                  "\nto make a 3 screenings for the chosen movie ");
              WriteLine(screenings.ScheduleScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");

              //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
              WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
              WriteLine(" ");
              WriteLine("Cinema Movies:");
              CinemaMovies.Display();
              WriteLine("**************************************************************************");
              WriteLine("Movie Play List:");
              MoviePlayList.Display();
              WriteLine(" ");

              WriteLine("Afrer using scheduleScreening() it automatically choose a movie use ChoosingNextMovie() " +
                  "\nto make a 3 screenings for the chosen movie ");
              WriteLine(screenings.ScheduleScreening(CinemaMovies, MoviePlayList).MNAME);
              WriteLine(" ");
              WriteLine("**************************************************************************");
              WriteLine("Display screening movies. ");
              screenings.Display();
              WriteLine(" ");

              //Choose next movie.
              /* WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, and put the chosen movie into Movie play list as queue structure. ");
                 WriteLine("Current chosen movie: "+screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();
                 WriteLine("**************************************************************************");
                 WriteLine("Movie Play List:");
                 MoviePlayList.Display();
                 WriteLine(" ");

                 //Choose next movie.
                 WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, and put the chosen movie into Movie play list  as queue structure. ");
                 WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();
                 WriteLine("**************************************************************************");
                 WriteLine("Movie Play List:");
                 MoviePlayList.Display();
                 WriteLine(" ");

                 //Choose next movie.
                 WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, and put the chosen movie into Movie play list  as queue structure. ");
                 WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();
                 WriteLine("**************************************************************************");
                 WriteLine("Movie Play List:");
                 MoviePlayList.Display();
                 WriteLine(" ");

                 //Choose next movie.
                 WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, and put the chosen movie into Movie play list  as queue structure. ");
                 WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();
                 WriteLine("**************************************************************************");
                 WriteLine("Movie Play List:");
                 MoviePlayList.Display();
                 WriteLine(" ");

                 //Choose next movie.
                 WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, and put the chosen movie into Movie play list  as queue structure. ");
                 WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();
                 WriteLine("**************************************************************************");
                 WriteLine("Movie Play List:");
                 MoviePlayList.Display();
                 WriteLine(" ");

                 //Choose next movie.
                 WriteLine("Once if Cinema Movies is empty, choose the first movie from Movie play list and put it the chosen movie to the end of Movie play list. ");
                 WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();
                 WriteLine("**************************************************************************");
                 WriteLine("Movie Play List:");
                 MoviePlayList.Display();
                 WriteLine(" ");

                 //Choose next movie.
                 WriteLine("Once if Cinema Movies is empty, choose the first movie from Movie play list and put it the chosen movie to the end of Movie play list. ");
                 WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();
                 WriteLine("**************************************************************************");
                 WriteLine("Movie Play List:");
                 MoviePlayList.Display();
                 WriteLine(" ");

                 //Receiving a new movie
                 WriteLine("Receiving another movie: Parasite.");
                 CinemaMovies.ReceivingAMovie(new Movie("Parasite", 20.00, new DateTime(2020, 11, 17)));
                 WriteLine(" ");
                 //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
                 WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
                 WriteLine(" ");
                 WriteLine("Cinema Movies:");
                 CinemaMovies.Display();




   
            

            //**************************
            //*** EFFICIENCY TESTING *** !!!( WHEN YOU DO EFFICIENCY TESTING, PLEASE COMMENT OUT FUCNTIONAL TESTING PART, VICE VERSA )
            //**************************


            //Use Linked List structure make a Cinema Customer List to add and delete customer infomation.
            //(Implement with clsses: Customer, CustomerList and CListNode)
            /*  CustomerList CinemaCustomerList = new CustomerList();

           //Customers
           Customer Micheal = new Customer("Michael", "Scott", "0434123456", "PayPal Pay");
           Customer Dwight = new Customer("Dwight", "Schrute", "0434123457", "Apple Wallet");
           Customer Jim = new Customer("Jim", "Halpert", "0434123455", "Credit Card");
           Customer Pam = new Customer("Pam", "Beesly", "0434123459", "PayPal Pay");
           Customer Angela = new Customer("Angela", "Martin", "0434123450", "Credit Card");
           Customer Kevin = new Customer("Kevin", "Malone", "0434123451", "Apple Wallet");       

           //Adding customers into Cinema Customer List
           WriteLine("Adding 6 customers into Cinema Customer List:");
           CinemaCustomerList.Adding(Micheal);
           WriteLine(CListNode.counter);
           CinemaCustomerList.Adding(Jim);
           WriteLine(CListNode.counter);
           CinemaCustomerList.Adding(Pam);
           WriteLine(CListNode.counter);
           CinemaCustomerList.Adding(Dwight);
           WriteLine(CListNode.counter);
           CinemaCustomerList.Adding(Angela);
           WriteLine(CListNode.counter);
           CinemaCustomerList.Adding(Kevin);
           WriteLine(CListNode.counter);

           //Display the customer list and count the number of customer
           WriteLine("\nDisplay the customer list and count the number of customer:");
           CinemaCustomerList.Display();
           CinemaCustomerList.CountNum();

           //Removing a customer from Cinema Customer List
           WriteLine("\nRemoving the 6th person from Cinema Customer List");
           CinemaCustomerList.Removing(Kevin);
           WriteLine(CustomerList.counter);
           WriteLine("\nRemoving the 3rd person from Cinema Customer List");
           CinemaCustomerList.Removing(Pam);
           WriteLine(CustomerList.counter);
           WriteLine("\nRemoving the 1st person from Cinema Customer List");
           CinemaCustomerList.Removing(Micheal);
           WriteLine(CustomerList.counter); 

           //Display the customer list and count the number of customer
           WriteLine("\nDisplay the customer list and count the number of customer:");
           CinemaCustomerList.Display();
           CinemaCustomerList.CountNum();
           WriteLine(" ");


           //Use stack structure make Cinema Movies for receiving a new movie.
           //(Implement with classes: Movie, MovieStack, MovieStackNode)
           MovieStack CinemaMovies = new MovieStack();
           WriteLine("Receiving 5 movies one by one ");

           //Receiving three movies.
           CinemaMovies.ReceivingAMovie(new Movie("The Matrix", 22.50, new DateTime(2015, 12, 11)));
           WriteLine(MovieStackNode.counter);
           CinemaMovies.ReceivingAMovie(new Movie("Spider-Man", 20.00, new DateTime(2017, 06, 01)));
           WriteLine(MovieStackNode.counter);
           CinemaMovies.ReceivingAMovie(new Movie("Fight Club", 20.50, new DateTime(2017, 12, 19)));
           WriteLine(MovieStackNode.counter);
           CinemaMovies.ReceivingAMovie(new Movie("Tenet", 22.00, new DateTime(2019, 10, 10)));
           WriteLine(MovieStackNode.counter);
           CinemaMovies.ReceivingAMovie(new Movie("Avengers:Endgame", 23.00, new DateTime(2020, 01, 17)));
           WriteLine(MovieStackNode.counter);
           //Disply all the received movies.
           WriteLine("Receiving three movies. Display all the movies:");
           CinemaMovies.Display();
           WriteLine(" ");


           //Use queue strectures make a Movie Play List and Screenings, combine with stack structure Cinema Movies to choose next movie .
           //(Implement with classes: Movie, MovieStack, MovieStackNode, MoviePlayQueue, Movie, ScreeningQueue, ScreeningQueueNode)
           MoviePlayQueue MoviePlayList = new MoviePlayQueue();
           ScreeningQueue screenings = new ScreeningQueue();
           WriteLine(" ");

           //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
         WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
           WriteLine(" ");
           WriteLine("Cinema Movies:");
           CinemaMovies.Display();
           WriteLine("**************************************************************************");
           WriteLine("Movie Play List:");
           MoviePlayList.Display();
           WriteLine(" ");

           //Choose next movie.
           WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, " +
               "\nand put the chosen movie into Movie play list as queue structure. ");
           WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
           WriteLine(" ");
           //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
           WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
           WriteLine(" ");
           WriteLine("Cinema Movies:");
           CinemaMovies.Display();
           WriteLine("**************************************************************************");
           WriteLine("Movie Play List:");
           MoviePlayList.Display();
           WriteLine(MovieStack.counter1+MovieQueueNode.counter2+MoviePlayQueue.counter3);
           WriteLine(" ");

           //Choose next movie.
           WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, " +
               "\nand put the chosen movie into Movie play list as queue structure. ");
           WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
           WriteLine(" ");
           //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
           WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
           WriteLine(" ");
           WriteLine("Cinema Movies:");
           CinemaMovies.Display();
           WriteLine("**************************************************************************");
           WriteLine("Movie Play List:");
           MoviePlayList.Display();
           WriteLine(MovieStack.counter1 + MovieQueueNode.counter2 + MoviePlayQueue.counter3);
           WriteLine(" ");

           //Choose next movie.
           WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, " +
               "\nand put the chosen movie into Movie play list as queue structure. ");
           WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
           WriteLine(" ");
           //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
           WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
           WriteLine(" ");
           WriteLine("Cinema Movies:");
           CinemaMovies.Display();
           WriteLine("**************************************************************************");
           WriteLine("Movie Play List:");
           MoviePlayList.Display();
           WriteLine(MovieStack.counter1 + MovieQueueNode.counter2 + MoviePlayQueue.counter3);
           WriteLine(" ");

           //Choose next movie.
           WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, " +
               "\nand put the chosen movie into Movie play list as queue structure. ");
           WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
           WriteLine(" ");
           //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
           WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
           WriteLine(" ");
           WriteLine("Cinema Movies:");
           CinemaMovies.Display();
           WriteLine("**************************************************************************");
           WriteLine("Movie Play List:");
           MoviePlayList.Display();
           WriteLine(MovieStack.counter1 + MovieQueueNode.counter2 + MoviePlayQueue.counter3);
           WriteLine(" ");


           //Choose next movie.
           WriteLine("Choose a movie.Automatically choose the most recent one from Cinema Movies, " +
               "\nand put the chosen movie into Movie play list as queue structure. ");
           WriteLine("Current chosen movie: " + screenings.ChoosingNextMovie(CinemaMovies, MoviePlayList).MNAME);
           WriteLine(" ");
           //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
           WriteLine("Display the movies in Cinema Movies and Movie Play List. ");
           WriteLine(" ");
           WriteLine("Cinema Movies:");
           CinemaMovies.Display();
           WriteLine("**************************************************************************");
           WriteLine("Movie Play List:");
           MoviePlayList.Display();
           WriteLine(MovieStack.counter1 + MovieQueueNode.counter2 + MoviePlayQueue.counter3);
           WriteLine(" ");



         //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
         WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
         WriteLine(" ");
         WriteLine("Cinema Movies:");
         CinemaMovies.Display();
         WriteLine("**************************************************************************");
         WriteLine("Movie Play List:");
         MoviePlayList.Display();
         WriteLine(" ");

         WriteLine("Using NextScreening() to schedule next screen ");
         WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
         WriteLine(ScreeningQueue.counter);
         WriteLine(" ");
         WriteLine("**************************************************************************");
         WriteLine("Display screening movies. ");
         screenings.Display();

         WriteLine(" ");
         WriteLine("Using NextScreening() to schedule next screen ");
         WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
         WriteLine(" ");
         WriteLine("**************************************************************************");
         WriteLine("Display screening movies. ");
         screenings.Display();
         WriteLine(" ");
         WriteLine("Using NextScreening() to schedule next screen ");
         WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
         WriteLine("**************************************************************************");
         WriteLine("Display screening movies. ");
         screenings.Display();
         WriteLine(" ");

         //Display the movies in stack structure Cinema Movies and queue structure Movie Play List.
         WriteLine("Display the movies in stack structure Cinema Movies and queue structure Movie Play List.");
         WriteLine(" ");
         WriteLine("Cinema Movies:");
         CinemaMovies.Display();
         WriteLine("**************************************************************************");
         WriteLine("Movie Play List:");
         MoviePlayList.Display();
         WriteLine(" ");


         WriteLine("Using NextScreening() to schedule next screen ");
         WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
         WriteLine("Counter in enqueue:"+ScreeningQueue.counter);
           WriteLine("Counter in dequeue:"+ScreeningQueue.counter9);
           WriteLine(" ");
         WriteLine("**************************************************************************");
         WriteLine("Display screening movies. ");
         screenings.Display();

           WriteLine("Using NextScreening() to schedule next screen ");
           WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
           WriteLine("Counter in enqueue:" + ScreeningQueue.counter);
           WriteLine("Counter in dequeue:" + ScreeningQueue.counter9);
           WriteLine(" ");
           WriteLine("**************************************************************************");
           WriteLine("Display screening movies. ");
           screenings.Display();

           WriteLine("Using NextScreening() to schedule next screen ");
           WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
           WriteLine("Counter in enqueue:" + ScreeningQueue.counter);
           WriteLine("Counter in dequeue:" + ScreeningQueue.counter9);
           WriteLine(" ");
           WriteLine("**************************************************************************");
           WriteLine("Display screening movies. ");
           screenings.Display();

           WriteLine("Using NextScreening() to schedule next screen ");
           WriteLine(screenings.NextScreening(CinemaMovies, MoviePlayList).MNAME);
           WriteLine("Counter in enqueue:" + ScreeningQueue.counter);
           WriteLine("Counter in dequeue:" + ScreeningQueue.counter9);
           WriteLine(" ");
           WriteLine("**************************************************************************");
           WriteLine("Display screening movies. ");
           screenings.Display();

           */


        }
    }
}
