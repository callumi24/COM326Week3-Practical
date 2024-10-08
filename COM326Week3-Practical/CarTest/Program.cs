using CarLibrary;

namespace CarTest
{
    public class CarTest
    {
        static void Main(String[] args)
        {
            Engine engine1 = new Engine(4, 210);
            Car car = new Car("Ford", "Fiesta", "2016", engine1);
            car.Drive();
            car.Stop();
        }
    }
}