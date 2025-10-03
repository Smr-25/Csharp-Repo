
namespace Pa201LabN4v2
{
    internal class PizzaService : IPizzaService
    {
        double max = 0;
        Pizza bigPizza;
        
        public Pizza AddPizza(string name,int radius,double calory,TimeSpan prepareTime,DateTime created)
        {
            Pizza pizza = new Pizza
            {
                FoodName = name,
                Radius = radius,
                CaloryValue = calory,
                PrepareTime = prepareTime,
                CreateDate = created
            };
            return pizza;
        }

        public Pizza BigRadiusPizza(List<Pizza> pizzas)
        {
            foreach (var item in pizzas)
            {
                if(item.Radius > max)
                {
                    max = item.Radius;
                    bigPizza = item;
                }
            }

            return bigPizza;
        }
    }
}

