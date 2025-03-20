public partial class Car
{
    public string GetCarInfo()
    {
        return $"{Brand} {Model}, Год: {Year}, Пробег: {Mileage} км";
    }
}