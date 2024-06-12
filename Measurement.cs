using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    public class Measurement
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public DateTime Timestamp { get; private set; }
        public double Temperature { get; private set; }
        public double CO2 { get; private set; }
        public int PeopleCount { get; private set; }
        public Locale Locale { get; private set; }

        public Measurement(double temperature, double co2, int peopleCount, Locale locale)
        {
            if (temperature < 0 || temperature > 50) throw new ArgumentException("Temperature must be between 0 and 50 degrees.");
            if (co2 < 0) throw new ArgumentException("CO2 level must be positive.");
            if (peopleCount < 0) throw new ArgumentException("People count must be positive.");

            Id = nextId++;
            Timestamp = DateTime.Now;
            Temperature = temperature;
            CO2 = co2;
            PeopleCount = peopleCount;
            Locale = locale;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Timestamp: {Timestamp}, Temperature: {Temperature}, CO2: {CO2}, People Count: {PeopleCount}, Locale: {Locale}";
        }
    }

}
