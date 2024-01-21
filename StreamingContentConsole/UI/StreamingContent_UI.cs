using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class StreamingContent_UI
{
     protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
     protected readonly List<Show> _showDirectory = new List<Show>();
     protected readonly List<Movie> _movieDirectory = new List<Movie>();
    private Movie movie;

    public void Run()
     {
        //seedData();
        RunApplication();
     }

        //Text-based menu
     private void RunApplication()
     {
        bool isRunning = true;
        while(isRunning)
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                " \t========== \n" +
                " \tX. Exit\n" +
                " \t========== \n"
                );

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine(
                " \t=================================== \n" +
                " \tGoal of this Console App:\n"  
            );

            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine(
                " \tTo implement a persistent storage application\n" +
                " \t for Movie and Show\n" 
            );

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                " \tPlease Select from the following: \n"
                );

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(
                " \t      Movies \n" +
                "\t ----------------- \n"
                );

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                " \t1. AddMovie\n" +
                " \t2. GetAllMovie\n" +
                " \t3. UpdateMovie\n" +
                " \t4. DeleteMovie \n"
                );

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(
                " \t      Shows \n" +
                "\t ----------------- \n"
                );

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                " \t5. AddShow\n" +
                " \t6. GetAllShow\n" +
                " \t7. UpdateShow\n" +
                " \t8. DeleteShow \n"
                );


                Console.ResetColor();


            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
               case "x":
                isRunning = CloseApplication();
                break;

               case "1":
                    AddMovie();
                    break;
               case "2":
                    //GetAllMovie();
                    break;
               case "3":
                    //UpdateMovie();
                    break;
               case "4":
                   // DeleteMovie();
                    break;
               case "5":
                  //  AddShow();
                    break;
               case "6":
                  //  GetAllShow();
                    break;
               case "7":
                  //  UpdateShow();
                    break;
               case "8":
                    //DeleteShow();
                    break;

                default:
                System.Console.WriteLine("invalid Selection");
                PressAnyKey();
                break;

             }
        
         }

      }

      // Movies Methodes

      private void AddMovie()
      {
            Console.Clear();
            System.Console.WriteLine("Would you like to add this Movie ? y/n");

            string userResponse = Console.ReadLine().ToLower();

            if(userResponse == "y")
        {
            int startingCount = _movieDirectory.Count;
            _movieDirectory.Add(movie);
            bool wasAdded = (_movieDirectory.Count > startingCount)? true : false;

        }

            
      }

    private bool CloseApplication()   // this f(x) made line 47 to work.
    {    
      Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        System.Console.WriteLine("\"Have a good day.\"");
        Console.ResetColor();
        PressAnyKey();
        return false;
    }

    private void PressAnyKey()   // this f(x) made line 51 to work.
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine("\tPress Any Key to Continue...");
        Console.ResetColor();
        Console.ReadKey();
    }
}
