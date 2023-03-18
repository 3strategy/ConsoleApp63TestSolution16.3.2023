namespace ConsoleApp63TestSolution16._3._2023
{

  /// <summary>
  /// Q3 המחלקה עט
  /// </summary>
  public class Pen
  {
    //לא נדרש לרשום את השדות
    private string made;
    private double price;
    private string color;
    private int weight;

    public Pen(string made)
    {
      this.made = made;
      price = 10;
      color = "red";
      weight = 25;
    }
    public void SetPrice(double value)
    {
      price = value; //  this.price = price //SetPrice(double price) וכמובן לקבל
    }

    public bool IsSamePrice(Pen other)
    {
      return this.price == other.price;
    }

    public bool IsSamePrice2(Pen other) => price == other.price;
  }
}
