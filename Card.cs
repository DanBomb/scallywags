namespace scallywags
{
  public class Card
  {
    private string title = "Card1";
    private string desc = "This is a card";
    private int effect = 2;
    private string type = "General";

    public Card(string Title, string Description, int Effect, string Type)
    {
      title = Title;
      desc = Description;
      effect = Effect;
      type = Type;
    }

    public string Title()
    {
      return title;
    }

    public string Description()
    {
      return desc;
    }

    public int Effect()
    {
      return effect;
    }

    public string Type()
    {
      return type;
    }
  }
}