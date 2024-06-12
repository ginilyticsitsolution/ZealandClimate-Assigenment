using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    public class MeasurementRegister
    {
        private List<Measurement> measurements;

        public MeasurementRegister()
        {
            measurements = new List<Measurement>();
        }

        public void CreateMeasurement(double temperature, double co2, int peopleCount, Locale locale)
        {
            var measurement = new Measurement(temperature, co2, peopleCount, locale);
            measurements.Add(measurement);
        }

        public Measurement GetMeasurement(int id)
        {
            return measurements.FirstOrDefault(m => m.Id == id);
        }

        public void PrintAllMeasurements()
        {
            foreach (var measurement in measurements)
            {
                Console.WriteLine(measurement);
            }
        }

        public int NumberIllegalCO2Measurements()
        {
            return measurements.Count(m => m.CO2 > 1000);
        }

        public List<Measurement> AllTempUnderOver(int min, int max)
        {
            return measurements.Where(m => m.Temperature < min || m.Temperature > max).ToList();
        }
    }

}
