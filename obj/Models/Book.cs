namespace Name
{
  // NOTE maybe make this abstract
  // REVIEW Why was this put as public and not in the Blockbuster example?
  public class Book
  {

    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author, string description, bool IsAvailable)
    {
      Title = title;
      Author - author;
      Description = description;
      IsAvailable = true;

    }

  }
}