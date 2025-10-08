
using System.Text;
using ConsoleApp11;

string path = "C:\\Users\\samiraa\\Desktop\\Lab\\ConsoleApp11\\ConsoleApp11\\Files\\";

if (!Directory.Exists(path))
    Directory.CreateDirectory(path);


path += "Database.json";

if (!File.Exists(path))
    File.Create(path);

Department department = new();
department.AddEmployee();
