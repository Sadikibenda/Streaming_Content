
public class StreamingContent 
{
   public string Title {get; set;}
   public string Description {get; set;}
   public double StarRating {get; set;}
   public MaturityRating MaturityRating {get; set;}
   //public bool IsFamilyFriendly {get; set;}

   public GenreType TypeOfGenre {get; set;}

    public StreamingContent() {} 
   public StreamingContent(string title, string description, MaturityRating maturityRating, double stars, GenreType typeofgenre)
   {
    Title = title;
    Description = description;
    MaturityRating = maturityRating;
    StarRating = stars;
    TypeOfGenre = typeofgenre;
    //IsFamilyFriendly = familyFriendly;
   }

     public bool IsFamilyFriendly
    {
        get
        {
            switch(MaturityRating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                case MaturityRating.TV_Y:
                case MaturityRating.TV_G:
                case MaturityRating.TV_PG:
                    return true;
                default:
                    return false;
            }
        }
    }
}

public enum GenreType 
{
    Horror = 1,
    RomCom,
    SciFi,
    Documentary,
    Bromance,
    Drama,
    Action,
    Fantasy,  // double check (,) at the end.
}

/* Users have been complaining about their family-friendly content. Some users have been reporting that when filtering 
for family-friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. 
The maturity rating and family-friendly bool are independent; we need to tie them together. 
If something is rated R (or another similar rating), it should never be able to have an IsFamilyFriendly of true.
We need you to refactor the code StreamingContent class. To help narrow down our problem, 
we want to replace the MaturityRating with a default set of options.
We want our IsFamilyFriendly to return true or false based on those options. */

public enum MaturityRating
{
    G,
    PG,
    PG_13,
    R,
    NC_17,
    TV_Y,
    TV_G,
    TV_PG,
    TV_14,
    TV_MA
}

 