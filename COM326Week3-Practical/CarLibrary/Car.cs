using CarLibrary;

public class Car
{
    private string make;
    private string model;
    private string year;
    Engine Engine;

    public string Make { get { return make; } set { make = value; } }
    public string Model { get { return model; } set { model = value; } }
    public string Year { get { return year; } set { year = value; } }

    public Car()
    {
        make = "BMW";
        model = "M3";
        year = "2013";
        Engine = new Engine();
    }

    public Car(string make, string model, string year, Engine engine)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        Engine = new Engine();
    }

    public void Drive()
    {
        Console.WriteLine("Driving starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Driving stopped.");
    }
}
