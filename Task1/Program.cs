class A
{
    private int a;
    private int b;

    public A(int a, int b)
    {
        this.a = a; 
        this.b = b;
    }

    public int CalculateProduct()
    {
        return a * b;
    }

    public double CalculateExpression()
    {
        if (a - b == 0)
        {
            throw new InvalidOperationException("Делить на ноль нельзя");
        }
        return Math.Sqrt(b) / (2 * a);
    }
    
    public void Display()
    {
        Console.WriteLine($"a: {a}, b: {b}");
        Console.WriteLine($"Произведение a и b: {CalculateProduct()}");
        Console.WriteLine($"Результат выражения: {CalculateExpression()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        A obj = new A(10, 25);
        obj.Display();
    }
}