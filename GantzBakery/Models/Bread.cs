namespace GantzBakery.Models
{
  public class Bread
  {
    public int CostPerBread { get; set; }
    public static int BreadTotal(int orderBread)
    {
      int CostPerBread = 5;
      int BreadSubtotal = 0;
      if (orderBread % 3 == 0)
      {
        BreadSubtotal = (orderBread * CostPerBread - ((orderBread /3 ) * CostPerBread));
      }
      else orderBread = 123;
      return CostPerBread;
    }
  }
}