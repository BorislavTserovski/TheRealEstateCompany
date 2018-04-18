namespace TheRealEstateCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Estate
    {
        public int Id { get; set; }

        public double TotalArea { get; set; }

        public decimal PricePerSquareMeter { get; set; }

        public Location Location { get; set; }

        public override string ToString()
        {
            return ($"Location : {this.Location} ; Area : {this.TotalArea}; Price per square meter : {this.PricePerSquareMeter};");
        }

        public abstract decimal CalculateTotalPrice();

    }
}
