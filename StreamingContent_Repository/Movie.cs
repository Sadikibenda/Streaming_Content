
public class Movie : StreamingContent 
{
    public double RunTime {get; set; }
    public string Director {get; set; }

    // If you or the students think of any other properties
    // that a movie would have, but not a show, you can add them
    
    public Movie (){}
    public Movie ( double runtime, string director, string title, string description, double starRating, MaturityRating maturityRating, GenreType typeofgenre)
    {
        this.RunTime = runtime;
        this.Director = director;
        Title = title;
        Description = description;
        StarRating = starRating;
        MaturityRating = maturityRating;
        TypeOfGenre = typeofgenre;
    }

    //Create
    /*public bool AddMovie(Movie movie)
    {
        int startingCount = _contentDirectory.Count;
        _contentDirectory.Add(movie);
        bool wasAdded = (_contentDirectory.Count > startingCount)? true : false;

        return wasAdded;
    }

    //Read
    /*
    public List<MovieContent> GetAllMovies()
    {
        return _contentDirectory;
    }

    public MovieContent GetContentbyTitle(string title)
    {
        foreach(MovieContent content in _contentDIrectory)
        {
            if(content.Title.ToLower() == title.Tolower())
            {
                return content;
            }
        }
        return null;
    }

    //update
    public bool updateMovie()
    {
        MovieContent oldContent = GetContentbyTitle(originalTitle);
        if(oldContent != null)
        {
            oldContent.Title = newContent.Title;
            oldContent.Description = newContent.Description;
            oldContent.StarRating = newContent.StarRating;
            oldContent.MaturityRating = newContent.MaturityRating;
            oldContent.TypeOfGenre = newContent.TypeOfGenre;

            return true;
        }
        else
        {
            return false;
        }
        
    }

    //Delete
    public bool DeleteMovie()
    {
        bool deleteResult = _contentDirectory.Remove(existingContent);
        return deleteResult;
    }
    */
}