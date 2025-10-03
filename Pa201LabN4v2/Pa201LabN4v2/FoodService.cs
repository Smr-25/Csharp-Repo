using Pa201LabN4v2;
namespace Pa201LabN4v2
{
    internal class FoodService : IFoodService
    {
        public int CountOfCalory(List<Food> foods, int n)
        {
            int count = 0;
            foreach (var item in foods)
            {
                if (item.CaloryValue > n)
                {
                    count++;
                }
            }

            return count;
        }

        public DateTime WhenWillPrepared(Food food)
        {
            return food.CreateDate.Add(food.PrepareTime);
        }
    }
}
