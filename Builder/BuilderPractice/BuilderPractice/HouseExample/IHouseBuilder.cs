using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPractice.HouseExample
{
    public interface IHouseBuilder
    {
        void SetNumberWalls(int numberWalls);
        void SetNumberDoors(int numberDoors);
        void SetNumberWindows(int numberWindows);
        void HasPool();
        void HasGarden();
        void HasStatues();
        void ShowInfo();
        void SetType(string type);
    }
}
