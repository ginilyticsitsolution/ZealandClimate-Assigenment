using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    public class Locale
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public string RoomNumber { get; set; }
        public int MaxNumber { get; set; }

        public Locale(string roomNumber, int maxNumber)
        {
            Id = nextId++;
            RoomNumber = roomNumber;
            MaxNumber = maxNumber;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Room Number: {RoomNumber}, Max Number: {MaxNumber}";
        }
    }

}
