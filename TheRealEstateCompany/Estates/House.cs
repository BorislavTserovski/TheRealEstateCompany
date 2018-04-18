
namespace TheRealEstateCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class House : Estate
    {
        public double YardArea { get; set; }

        public double BuildingArea { get; set; }

        public int NumberOfFloors { get; set; }

        public bool IsFurnished { get; set; }

        public override decimal CalculateTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
