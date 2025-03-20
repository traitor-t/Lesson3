public abstract class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; }

    public Employee(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}

public sealed class Manager : Employee
{
    public Manager(string name, int age, decimal salary):base(name, age, salary)
    {
    }
}

public sealed class Developer : Employee
{
    public Developer(string name, int age, decimal salary) : base(name, age, salary)
    {
    }
}

public class Company
{
    private List<Employee> employees;
    public Company()
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public Employee GetHighestPaiEmployee()
    {
        return employees.OrderByDescending(e => e.Salary).FirstOrDefault();
    }

    public double getAverageAge()
    {
        if (employees.Count == 0) return 0;
        return employees.Average(e => e.Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Company company = new Company();
        company.AddEmployee(new Manager("Alice", 45, 80000));
        company.AddEmployee(new Developer("Alex", 35, 85000));
        company.AddEmployee(new Developer("Bob", 30, 90000));
        company.AddEmployee(new Manager("Kate", 25, 75000));

        var highestPaid = company.GetHighestPaiEmployee();
        if (highestPaid != null)
        {
            Console.WriteLine($"Сотрудник с самой высокой зарплатой: {highestPaid.Name}, Зарплата: {highestPaid.Salary}");
        }

        double averageAge = company.getAverageAge();
        Console.WriteLine($"Средний возраст сотрудников: {averageAge}");
    }
}