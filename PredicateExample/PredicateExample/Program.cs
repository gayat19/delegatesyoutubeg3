namespace PredicateExample
{
    internal class Program
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{Id=101,Name="ABC",Age=22},
            new Employee{Id=102,Name="XYZ",Age=29},
            new Employee{Id=103,Name="EFG",Age=36}
        };
        void findEmployee()
        {
            Console.WriteLine("Please enter the employee name to check");
            string name = Console.ReadLine()??"ABC";
            //Predicate<Employee> checkEmployee = new Predicate<Employee>(emp => emp.Name == name);
            //Console.WriteLine(checkEmployee(new Employee { Name = name })) ;
            //Employee myEmployee = employees.Find(checkEmployee);
            Employee myEmployee = employees.Find(emp => emp.Name == name);
            Console.WriteLine(myEmployee);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.findEmployee();
            Console.ReadKey();
        }
    }
    class Employee
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return Id+" "+Name+" "+Age;
        }
    }
}