
public class Movie : StreamingContent 
{
    public double RunTime {get; set; }
    public string Director {get; set; }

    // If you or the students think of any other properties
    // that a movie would have, but not a show, you can add them
    
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
}