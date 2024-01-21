
public class MovieContentRepository
{
    //Create
    protected readonly List<Movie> _movieDirectory = new List<Movie>();
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
    public bool updateMovie(string originalTitle, Movie newmovie)
    {
        Movie oldmovie = GetMoviebyTitle(originalTitle);
        if(oldmovie != null)
        {
            oldmovie.Title = newmovie.Title;
            oldmovie.Description = newmovie.Description;
            oldmovie.StarRating = newmovie.StarRating;
            oldmovie.MaturityRating = newmovie.MaturityRating;
            oldmovie.TypeOfGenre = newmovie.TypeOfGenre;

            return true;
        }
        else
        {
            return false;
        }
        
    }

    //Delete
    public bool DeleteMovie(Movie existingmovie)
    {
        bool deleteResult = _movieDirectory.Remove(existingmovie);
        return deleteResult;
    }
}