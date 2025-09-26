
namespace Pa201LabN4v2
{
    public abstract class Food
    {
        public int Id { get; set; }
        public  string FoodName { get; set; }
        public  DateTime CreateDate { get; set; }
        public  int PrepareTime { get; set; }

        public uint CaloryValue { get; set; }

        public abstract double  CalcPrice();
    }
}
