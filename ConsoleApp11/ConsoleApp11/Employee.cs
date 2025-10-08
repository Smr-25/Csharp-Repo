namespace ConsoleApp11
{
    internal class Employee
    {
       
        public Employee( string name, int salary)
        {
            Id ++;
            Name = name;
            Salary = salary;
        }

        public static int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {Name} {Salary}");
        }
    }
}
