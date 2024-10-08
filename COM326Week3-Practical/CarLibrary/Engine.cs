using System.Xml.Linq;

namespace CarLibrary
{
    public class Engine
    {
        private int cylinders;
        private double horsepower;

        public int Cylinders { get { return cylinders; } set { cylinders = value; } }
        public double Horsepower { get { return horsepower; } set  { horsepower = value; } }

        public Engine()
        {
            cylinders = 5;
            horsepower = 150;
        }

        public Engine(int cylinders, double horsepower)
        {
            this.cylinders = cylinders;
            this.horsepower = horsepower;
        }

        public void Start()
        {
            Console.WriteLine("Engine starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopping...");
        }
    }
}
