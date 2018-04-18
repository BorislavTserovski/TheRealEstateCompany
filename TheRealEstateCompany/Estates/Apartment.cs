namespace TheRealEstateCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Apartment : Estate
    {
        public int FloorNumber { get; set; }

        public bool HasElevator { get; set; }

        public bool IsFurnished { get; set; }

        public override decimal CalculateTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}