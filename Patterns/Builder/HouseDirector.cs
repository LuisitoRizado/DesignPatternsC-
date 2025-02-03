using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoDesignPatterns.Patterns.Builder
{
    public class HouseDirector
    {
        public IHouseBuilder _houseBuilder;

        public IHouseBuilder HouseBuilder
        {
            set { _houseBuilder = value; }
        }

        public void BuildWalls()
        {
            this._houseBuilder.BuildWalls();
        }

        public void BuildFullHouse()
        {
            this._houseBuilder.BuildGarage();
            this._houseBuilder.BuildWalls();
        }

    }
}
