using Pa201LabN4v2;
// this thing
var pizza = new Pa201LabN4v2.Pizza
{
    Id = 1,
    FoodName = "Pepperoni",
    CreateDate = DateTime.Now,
    PrepareTime = 15,
    CaloryValue = 800,
    Radius = 12.5,
    IsSpicy = true
};

Console.WriteLine(pizza);


var fries = new Pa201LabN4v2.Fries
{
    Id = 2,
    FoodName = "French Fries",
    CreateDate = DateTime.Now,
    PrepareTime = 10,
    CaloryValue = 350,
    Weight = 150,
    IsSalty = true
};

Console.WriteLine(fries);