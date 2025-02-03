
namespace DiveIntoDesignPatterns.Patterns.Builder
{
    public class HouseWithWalls : IHouseBuilder
    {
        private House _house = new House();
        public HouseWithWalls()
        {
        }
        public void Reset()
        {
            this._house = new House();
        }
        public void BuildWalls()
        {
            this._house.Add("Walls Added");
        }

        public void BuildGarage()
        {
            this._house.Add("GarageAdded");
        }

        public House GetHouse()
        {
            House result = this._house;
            this.Reset();
            return result;
        }
    }
}
