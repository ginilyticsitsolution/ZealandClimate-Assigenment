using ZealandClimate;

class Program
{
    static void Main(string[] args)
    {
        var locale1 = new Locale("D.3.06", 36);
        var locale2 = new Locale("A.1.01", 20);

        var register = new MeasurementRegister();
        register.CreateMeasurement(22.5, 900, 30, locale1);
        register.CreateMeasurement(18.0, 1100, 15, locale2);
        register.CreateMeasurement(25.0, 700, 40, locale1);

        Console.WriteLine("All Measurements:");
        register.PrintAllMeasurements();

        Console.WriteLine("\nNumber of Illegal CO2 Measurements:");
        Console.WriteLine(register.NumberIllegalCO2Measurements());

        Console.WriteLine("\nMeasurements with Temperature Outside 20-22 Degrees:");
        var tempOutOfRange = register.AllTempUnderOver(20, 22);
        foreach (var measurement in tempOutOfRange)
        {
            Console.WriteLine(measurement);
        }

        Console.WriteLine("\nSpecific Measurement with ID 2:");
        var specificMeasurement = register.GetMeasurement(2);
        if (specificMeasurement != null)
        {
            Console.WriteLine(specificMeasurement);
        }
        else
        {
            Console.WriteLine("Measurement not found.");
        }
    }
}
