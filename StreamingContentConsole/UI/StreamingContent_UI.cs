using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


 public class StreamingContent_UI
{
    MovieContentRepository _MRepo = new MovieContentRepository();
    ShowContentRepository _SRepo = new ShowContentRepository();
    StreamingContentRepository _STRepo = new StreamingContentRepository();
    

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
                    GetAllMovies();
                    break;

                case "3":
                    updateMovie();
                    break;

                case "4":
                    DeleteMovie();
                    break;

                case "5":
                    AddShow();
                    break;

                case "6":
                    GetAllShows();
                    break;

                case "7":
                    updateShow();
                    break;
                    
                case "8":
                    DeleteShow();
                    break;                        

                default:
                System.Console.WriteLine("invalid Selection");
                PressAnyKey();
                break;

             }
        
         }

      }

      // Movies Methodes

      public void AddMovie()
      {
        Movie newmovie = new Movie(0.0, "","", "", 0.0, MaturityRating.R, GenreType.Drama);

        Console.WriteLine("Please Type a movie title.");
        newmovie.Title = Console.ReadLine();

        Console.WriteLine("Please type Director of this movie.");
        newmovie.Director = Console.ReadLine();

        Console.WriteLine("Please type Description of this movie");
        newmovie.Description = Console.ReadLine();

        Console.WriteLine("Please type Runtime of this movie");
        newmovie.RunTime = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please type Star Rating of this movie");
        newmovie.StarRating = Convert.ToDouble(Console.ReadLine());

      /* Console.WriteLine("Please type maturity rating of this movie.");   MaturityRating.ToString()
        newmovie.MaturityRating = (MaturityRating)int.Parse(Console.ReadLine()); */// Will work on this later.

      /* Console.WriteLine("Please type maturity rating of this movie.");
        foreach(string i in Enum.GetNames(typeof(MaturityRating)))
        {
            Console.WriteLine($"{i}");
        }*/


        _MRepo.AddMovie(newmovie);    
      }

      private void GetAllMovies()
      {
        Console.WriteLine("Here are your Movie(s)");
        
        // get list of movies
        List<Movie> movies = _MRepo.GetAllMovies();
        Console.WriteLine("movie in list= " + movies.Count);

        //get each movie
        for(int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine("Movie Title= " + movies[i].Title);
        } 
        
      }

    private void updateMovie()
    {   
       Console.WriteLine("Please enter the # of show you would like to update");
       List<Movie> movies = _MRepo.GetAllMovies();

       for(int i = 0; i < movies.Count; i++)
       {
        Console.WriteLine(i + "." + movies[i].Title);
       }

       string updateinput = Console.ReadLine();
        Console.WriteLine(" Movie to update " + updateinput);
        Console.WriteLine(" Enter 1 to update Title");
        Console.WriteLine(" Enter 2 to update Description");
        Console.WriteLine(" Enter 3 to update StarRating");

       
       string updateMovieinput = Console.ReadLine();
        switch (updateMovieinput)
        {
            case "1":
                Console.WriteLine("update Title");
                break;

            case "2":
                Console.WriteLine("update Description");
                break;

            case "3":
                Console.WriteLine("update StartRating");
                break;

            default:
                Console.WriteLine("invalid Selection");
                break;
        } 

        string updateData = Console.ReadLine();
        _MRepo.updateMovie(updateinput, updateMovieinput, updateData);
    }

    private void DeleteMovie()
    {   
        
        Console.WriteLine("Please enter a number of movie you would like to Delete");

        List<Movie> movies = _MRepo.GetAllMovies();

        for(int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine(i + " " + movies[i].Title);
        } 

        string input = Console.ReadLine();
        Console.WriteLine("Delete Movie: " + input);

           _MRepo.DeleteMovieById(input);
        
    }

    // Show Methodes

    private void AddShow()
    {
        Show newshow = new Show();

        Console.WriteLine("Please Type a Show title.");
        newshow.Title = Console.ReadLine();

        Console.WriteLine("Please type Director of this show.");
        newshow.Description = Console.ReadLine();

        Console.WriteLine("Please type Star Rating of this show.");
        newshow.StarRating = Convert.ToDouble(Console.ReadLine());

        _SRepo.AddShow(newshow);
    }

    private void GetAllShows()
    {
        Console.WriteLine("Here are your Show(s)");

        //get all shows
        List<Show> shows = _SRepo.GetAllShows();
        Console.WriteLine("Show List: " + shows.Count);

        // get each 

        for(int i = 0 ; i < shows.Count ; i++)
        {
            Console.WriteLine(i + "." + shows[i].Title);
        }

    }

    private void updateShow()
    {
        Console.WriteLine("Please enter the # of show you would like to update");
        List<Show> shows = _SRepo.GetAllShows();

        for(int i = 0; i < shows.Count; i++)
        {
            Console.WriteLine(i + "." + shows[i].Title);
        }

        string updateinput = Console.ReadLine();
        Console.WriteLine(" Movie to update " + updateinput);
        Console.WriteLine(" Enter 1 to update Title");
        Console.WriteLine(" Enter 2 to update Description");
        Console.WriteLine(" Enter 3 to update StarRating");

       
       string updateshoweinput = Console.ReadLine();
        switch (updateshoweinput)
        {
            case "1":
                Console.WriteLine("update Title");
                break;

            case "2":
                Console.WriteLine("update Description");
                break;

            case "3":
                Console.WriteLine("update StartRating");
                break;

            default:
                Console.WriteLine("invalid Selection");
                break;
        } 

        string updateData = Console.ReadLine();
        _SRepo.updateShow(updateinput, updateshoweinput, updateData);
    }

    private void DeleteShow()
    {
        Console.WriteLine("Please enter a number of show you would like to Delete");
        List<Movie> shows = _MRepo.GetAllMovies();

        for(int i = 0; i < shows.Count; i++)
        {
            Console.WriteLine(i + " " + shows[i].Title);
        }

        string input = Console.ReadLine();
        _SRepo.DeleteMovieById(input);
    }


    private bool CloseApplication()   // this f(x) made line 86 to work.
    {    
      Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        System.Console.WriteLine("\"Have a good day.\"");
        Console.ResetColor();
        PressAnyKey();
        return false;
    }

    private void PressAnyKey()   // this f(x) made line 97 to work.
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine("\tPress Any Key to Continue...");
        Console.ResetColor();
        Console.ReadKey();
    }
}
