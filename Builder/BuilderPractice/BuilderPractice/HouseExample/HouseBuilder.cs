using BuilderPractice.VehicleExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPractice.HouseExample
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house;

        public HouseBuilder()
        {
            _house = new House();
        }

        public void ShowInfo()
        {
            _house.ShowInfo();
        }
       
        public void SetType(string type)
        {
            _house.HouseType = type;
        }
        public void HasGarden()
        {
            this._house.HasGarden = true;
        }

        public void HasPool()
        {
            this._house.HasPool = true;

        }

        public void HasStatues()
        {
            this._house.HasStatues = true;
        }

       

        public void SetNumberDoors(int numberDoors)
        {
            this._house.Doors = numberDoors;
        }

        public void SetNumberWalls(int numberWalls)
        {
            this._house.Walls = numberWalls;
        }

        public void SetNumberWindows(int numberWindows)
        {
            this._house.Windows = numberWindows;
        }
    }
}
