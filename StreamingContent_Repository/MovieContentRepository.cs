
public class MovieContentRepository
{
    //Create
    protected readonly List<Movie> _contentDirectory = new List<Movie>();
    public bool AddMovie(Movie movie)
    {
        int startingCount = _contentDirectory.Count;
        _contentDirectory.Add(movie);
        bool wasAdded = (_contentDirectory.Count > startingCount)? true : false;

        return wasAdded;
    }

    //Read
    public List<Movie> GetAllMovies()
    {
        return _contentDirectory;
    }

    public Movie GetMoviebyTitle(string title)
    {
        foreach(Movie movie in _contentDirectory)
        {
            if(movie.Title.ToLower() == title.ToLower())
            {
                return movie;
            }
        }
        return null;
    }
}