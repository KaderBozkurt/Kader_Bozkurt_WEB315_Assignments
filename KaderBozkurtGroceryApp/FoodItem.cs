using System;

namespace KaderBozkurtGroceryApp
{
public class FoodItem
{
    public string Title { get; set; }

    public string Isle {get; set;}

    public int Quantity {get; set;}

    public decimal Price { get; set; }
    
    public bool IsDone { get; set; }
}
}