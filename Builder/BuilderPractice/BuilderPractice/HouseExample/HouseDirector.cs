using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPractice.HouseExample
{
    public class HouseDirector
    {
        private readonly IHouseBuilder _houseBuilder;
        public HouseDirector(IHouseBuilder houseBuilder)
        {

            _houseBuilder = houseBuilder;
        }
        public void MakeBasicHouse( )
        {
            _houseBuilder.SetType("Basic house");
            _houseBuilder.SetNumberWindows(3);
            _houseBuilder.SetNumberWalls(4);
            _houseBuilder.SetNumberDoors(2);
        }
        public void MakePremiumHouse()
        {
            _houseBuilder.SetType("Premium house");
            _houseBuilder.SetNumberWindows(6);
            _houseBuilder.SetNumberWalls(8);
            _houseBuilder.SetNumberDoors(4);
            _houseBuilder.HasPool();
            _houseBuilder.HasGarden();
            _houseBuilder.HasStatues();
        }
        public void ShowInfo()
        {
            _houseBuilder.ShowInfo();
        }
    }
}
