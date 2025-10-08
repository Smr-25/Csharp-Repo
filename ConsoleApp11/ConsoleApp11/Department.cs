using System.Text.Json;

namespace ConsoleApp11
{
    internal class Department
    {
        public string path = "C:\\Users\\samiraa\\Desktop\\Lab\\ConsoleApp11\\ConsoleApp11\\Files\\Database.json";
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = [];

        public void AddEmployee()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(name, salary);

            Employees.Add(employee);
            using FileStream stream = new(path, FileMode.Append);
            using StreamWriter streamWriter = new StreamWriter(stream);

            string datas = JsonSerializer.Serialize(Employees);
            streamWriter.Write(datas);
        }

        public void GetEmployeeById()
        {

        }

        public void RemoveEmployee()
        {

        }
    }
}
