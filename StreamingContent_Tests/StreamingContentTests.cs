namespace StreamingContent_Tests;

[TestClass]
public class StreamingContentTests
{
    [TestMethod]
    public void SetTitle_ShouldSetCorrectString()
    {
        StreamingContent Content = new StreamingContent();

        Content.Title = "Toy Story";
        string expected = "Toy Story";
        string actual = Content.Title;

        Assert.AreEqual(expected,actual);
    }
    public void setDescription_ShouldSetCorrectString()
    {
        StreamingContent Content = new StreamingContent();

        Content.Description = "Help understand Toy Story";
        string expected = "Help understand Toy Story";
        string actual = Content.Description;

        Assert.AreEqual(expected,actual);
    }

    public void SetStarRating_ShouldSetCorrectStarRating()
    {
        StreamingContent Content = new StreamingContent();

        Content.StarRating = 4.2;
        double expected = 4.2;
        double actual = Content.StarRating;

        Assert.AreEqual(expected,actual);
    }

    [DataTestMethod]
    [DataRow(MaturityRating.G,true)]
    [DataRow(MaturityRating.TV_PG,true)]
    [DataRow(MaturityRating.R,false)]
    [DataRow(MaturityRating.TV_MA,false)]
    public void SetMaturityRating_ShouldGetCorrectFamilyFriendliness(MaturityRating rating, bool expectedFamilyFriendly)
    {
        // Triple A Paradigm, a short hand for setting up tests
        
        // Arrange => Setting the stage
        StreamingContent content = new StreamingContent("Content Title","Some description", rating, 4.2, GenreType.SciFi);
        
        // Act => We're executing any code that we need to run
        // If there were methods to call or properties to set, we'd do that here
        bool actual = content.IsFamilyFriendly;
        bool expected = expectedFamilyFriendly;
        
        // Assert => We're calling our asssertions finally
        Assert.AreEqual(expected, actual);
    }

}