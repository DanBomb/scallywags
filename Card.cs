namespace scallywags
{
  public class Card
  {
    private string title = "Card1";
    private string desc = "This is a card";

    public Card(string Title, string Description)
    {
      title = Title;
      desc = Description;
    }

    public string Title()
    {
      return title;
    }

    public string Description()
    {
      return desc;
    }
  }
}