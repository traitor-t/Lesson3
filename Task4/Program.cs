class Program
{
    static void Main(string[] args)
    {
        var fleet = new Fleet();
        fleet.AddCar(new Car("Toyota", "Camry", 2021, 15000));
        fleet.AddCar(new Car("Honda", "Civic", 2019, 30000));
        fleet.AddCar(new Car("Ford", "Focus", 2020, 10000));
        fleet.AddCar(new Car("Toyota", "Corolla", 2018, 25000));

        var newCars = fleet.GetNewestCars(2019);
        Console.WriteLine("Новые автомобили:");
        foreach (var car in newCars)
        {
            Console.WriteLine(car.GetCarInfo());
        }

        var toyotaCars = fleet.GetCarsByBrand("Toyota");
        Console.WriteLine("Автомобили марки Toyota:");
        foreach(var car in toyotaCars)
        {
            Console.WriteLine(car.GetCarInfo());
        }
    }
}