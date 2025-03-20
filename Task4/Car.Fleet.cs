public class Fleet
{
    private List<Car> cars;
    public Fleet()
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public List<Car> GetNewestCars(int year)
    {
        return cars.Where(c => c.Year == year).ToList();
    }

    public List<Car> GetCarsByBrand(string brand)
    {
        return cars.Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}