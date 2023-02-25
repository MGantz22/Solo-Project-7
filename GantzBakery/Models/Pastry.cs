namespace GantzBakery.Models
{
  public class Pastry
  {
    public static int CostPerPastry { get; set; }
    public static int PastySubtotal { get; set; }
    public static int PastryTotal(int orderPastry)
    {
      int CostPerPastry = 0;
      //int PastrySubtotal = 0; trying another way 
        if (orderPastry == 1)
        {
          CostPerPastry = 2;
        }
        else if (orderPastry == 2)
        {
          CostPerPastry = 4;
        }
        else if (orderPastry == 3)
        {
          CostPerPastry = 6;
        }
        else if (orderPastry == 4)
        {
          CostPerPastry = 6;
        }
        else if (orderPastry == 5)
        {
          CostPerPastry = 8;
        }
        else if (orderPastry == 6)
        {
          CostPerPastry = 10;
        }
        else if (orderPastry == 7)
        {
          CostPerPastry = 12;
        }
        else if (orderPastry == 8)
        {
          CostPerPastry = 12;
        }
        else 
        {
          int PastrySubtotal = orderPastry - 6;
            CostPerPastry = 8 + PastrySubtotal * 2;

        }
        return CostPerPastry;

    }
  }
}