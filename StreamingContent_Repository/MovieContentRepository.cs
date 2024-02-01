

public class MovieContentRepository
{
    //Create
    private readonly List<Movie> _movieDirectory = new List<Movie>();
    public bool AddMovie(Movie movie)
    {
        int startingCount = _movieDirectory.Count;
        _movieDirectory.Add(movie);
        bool wasAdded = (_movieDirectory.Count > startingCount)? true : false;

        return wasAdded;
    }

    //Read
    public List<Movie> GetAllMovies()
    {
        return _movieDirectory;
    }

    public Movie GetMoviebyTitle(string title)
    {
        foreach(Movie movie in _movieDirectory)
        {
            if(movie.Title.ToLower() == title.ToLower())
            {
                return movie;
            }
        }
        return null;
    }

    //update
    public void updateMovie(string updateinput, string updateMovieinput, string updateData)
    {
        Movie oldmovie = _movieDirectory[Convert.ToInt32(updateinput)];

        switch (updateMovieinput)
        {
            case "1":
                Console.WriteLine("update Title");
                oldmovie.Title = updateData;
                break;

            case "2":
                Console.WriteLine("update Description");
                oldmovie.Description = updateData;
                break;

            case "3":
                Console.WriteLine("update StartRating");
                oldmovie.StarRating = Convert.ToDouble(updateData);
                break;
        } 

        _movieDirectory[Convert.ToInt32(updateinput)] = oldmovie;
        
    }

    //Delete
    public bool DeleteMovie(Movie existingmovie)
    {
        bool deleteResult = _movieDirectory.Remove(existingmovie);
        return deleteResult;
    }

    public void DeleteMovieById(string input)
    {
         _movieDirectory.RemoveAt(Convert.ToInt32(input));
    }

    public void AddMovie()
    {
        throw new NotImplementedException();
    }

    public bool DeleteMovie(object existingmovie)
    {
        throw new NotImplementedException();
    }
}