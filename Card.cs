namespace scallywags
{
  public class Card
  {
    private string title = "Card1";
    private string desc = "This is a card";
    private string effect = "2";
    private string type = "General";

    public Card(string Title, string Description, string Effect, string Type)
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

    public string Effect()
    {
      return effect;
    }

    public string Type()
    {
      return type;
    }
  }
}