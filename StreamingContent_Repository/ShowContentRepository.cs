
public class ShowContentRepository
{
    protected readonly List<Show> _contentDirectory = new List<Show>();

    //Create

    public bool AddShow(Show show)
    {
        int startingCount = _contentDirectory.Count;
        _contentDirectory.Add(show);
        bool wasAdded = (_contentDirectory.Count > startingCount)? true : false;

        return wasAdded;
    }

    //Read
    public List<Show> GetAllShows()
    {
        return _contentDirectory;
    }

    public Show GetShowbyTitle(string title)
    {
        foreach(Show show in _contentDirectory)
        {
            if(show.Title.ToLower() == title.ToLower())
            {
                return show;
            }
        }
        return null;
    }

    //update
    public bool updateShow(string originalTitle, Show newshow)
    {
        Show oldshow = GetShowbyTitle(originalTitle);
        if(oldshow != null)
        {
            oldshow.Title = newshow.Title;
            oldshow.Description = newshow.Description;
            oldshow.StarRating = newshow.StarRating;
            oldshow.MaturityRating = newshow.MaturityRating;
            oldshow.TypeOfGenre = newshow.TypeOfGenre;

            return true;
        }
        else
        {
            return false;
        }
        
    }

    //Delete
    public bool DeleteShow(Show existingshow)
    {
        bool deleteResult = _contentDirectory.Remove(existingshow);
        return deleteResult;
    }
}