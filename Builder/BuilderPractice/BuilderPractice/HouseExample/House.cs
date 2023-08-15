using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPractice.HouseExample
{
    public class House
    {
        public string HouseType { get; set; }
        public int Walls { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }
        public bool HasPool { get; set; } = false;
        public bool HasGarden { get; set; } = false;
        public bool HasStatues { get; set; } = false;
        public House()
        {
        }

        public void ShowInfo()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("House Type: {0}", HouseType);
            Console.WriteLine(" Walls : {0}", Walls);
            Console.WriteLine(" Doors : {0}", Doors);
            Console.WriteLine(" Windows : {0}", Windows);
            Console.WriteLine(" Pool: {0}", HasPool);
            Console.WriteLine(" Garden : {0}", HasGarden);
            Console.WriteLine(" Statues : {0}", HasStatues);
        }

    }
}
