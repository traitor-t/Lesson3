public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public static class ArrayOperations
{
    public static List<Person> SortByAge(Person[] people)
    {
        return people.OrderBy(p => p.Age).ToList();
    }

    public static List<Person> FilterByAge(Person[] people, int AgeLimit = 30)
    {
        return people.Where(p => p.Age > AgeLimit).ToList();
    }

    public static double CalculateAverageAge(Person[] people)
    {
        if (people.Length == 0) return 0;
        return people.Average(p => p.Age);
    }

    public static Person[] GenerateData(int numberOfPeople)
    {
        Random random = new Random();
        Person[] people = new Person[numberOfPeople];
        
        for (int i = 0; i < numberOfPeople; i++)
        {
            string name = $"Peson {i + 1}";
            int age = random.Next(20, 60);
            people[i] = new Person(name, age);
        }
        return people;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = ArrayOperations.GenerateData(10);
        var filteredPeople = ArrayOperations.FilterByAge(people);
        Console.WriteLine("Люди старше 30 лет:");

        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Имя: {person.Name}, возраст: {person.Age}");
        }

        double averageAge = ArrayOperations.CalculateAverageAge(people);
        Console.WriteLine($"Средний возраст: {averageAge}");

        var sortedPeople = ArrayOperations.SortByAge(people);
        Console.WriteLine($"Люди, отсортированные по возрасту: ");
        
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"Имя: {person.Name}, возраст: {person.Age}");
        }
    }
}