namespace Ovning_1_Personalregister;

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

class EmployeeRegister
{
    private List<Employee> Employees = new List<Employee>();

    public void AddEmployee(string name, decimal salary)
    {
        Employees.Add(new Employee(name, salary));
        Console.WriteLine($"{name} tillagd\n");
    }

    public void PrintEmployees()
    {
        Console.WriteLine("\n --- Personalregister ---");
        if (Employees.Count == 0)
        {
            Console.WriteLine("Inga anställda finns i registret.");
        }
        else
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($"Namn: {employee.Name}, Lön: {employee.Salary}.");
            }
        }
        Console.WriteLine("");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeRegister register = new EmployeeRegister();

        while (true)
        {
            Console.WriteLine("1. Lägg till anställd");
            Console.WriteLine("2. Visa personregistret");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj ett alternativ: ");

            string menuChoice = Console.ReadLine();
            Console.WriteLine("");

            switch (menuChoice)
            {
                case "1":
                    Console.Write("Ange namn: ");
                    string name = Console.ReadLine();
                    
                    Console.Write("Ange lön: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal salary))
                    {
                        register.AddEmployee(name, salary);
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning av lönen.\n");
                    }
                    break;
                
                case "2":
                    register.PrintEmployees();
                    break;
                
                case "3":
                    Console.WriteLine("Programmet avslutas");
                    return;
                
                default:
                    Console.WriteLine("Felaktivt val. Var god försök igen.\n");
                    break;
            }
        }
    }
}