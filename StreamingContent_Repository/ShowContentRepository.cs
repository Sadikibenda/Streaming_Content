
public class ShowContentRepository
{
    protected readonly List<Show> _showDirectory = new List<Show>();

    //Create

    public bool AddShow(Show show)
    {
        int startingCount = _showDirectory.Count;
        _showDirectory.Add(show);
        bool wasAdded = (_showDirectory.Count > startingCount)? true : false;

        return wasAdded;
    }

    //Read
    public List<Show> GetAllShows()
    {
        return _showDirectory;
    }

    public Show GetShowbyTitle(string title)
    {
        foreach(Show show in _showDirectory)
        {
            if(show.Title.ToLower() == title.ToLower())
            {
                return show;
            }
        }
        return null;
    }

    //update
    public void updateShow(string updateinput, string updateshowinput, string updateData)
    {
       Show oldshow = _showDirectory[Convert.ToInt32(updateinput)];

        switch (updateshowinput)
        {
            case "1":
                Console.WriteLine("update Title");
                oldshow.Title = updateData;
                break;

            case "2":
                Console.WriteLine("update Description");
                oldshow.Description = updateData;
                break;

            case "3":
                Console.WriteLine("update StartRating");
                oldshow.StarRating = Convert.ToDouble(updateData);
                break;
        } 

        _showDirectory[Convert.ToInt32(updateinput)] = oldshow;

    }

    //Delete
    public bool DeleteShow(Show existingshow)
    {
        bool deleteResult = _showDirectory.Remove(existingshow);
        return deleteResult;
    }

    public void DeleteMovieById( string input)
    {
        _showDirectory.RemoveAt(Convert.ToInt32(input));
    }
}