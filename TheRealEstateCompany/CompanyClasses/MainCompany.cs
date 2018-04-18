
namespace TheRealEstateCompany.CompanyClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainCompany
    {
        
        private string name;
        private Employee owner;
        private string bulstat;

        public MainCompany()
        {
          
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name of the company is required!");
                }
                this.name = value;
            }
        }

        public Employee Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public string Bulstat
        {
            get
            {
                return this.bulstat;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Bulstat is required");
                }
                this.bulstat = value;
            }
        }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<Estate> Estates { get; set; } = new List<Estate>();

        public override string ToString()
        {
            return ($"{this.Name}; Owner: {this.owner.FirstName} {this.owner.LastName}; Bulstat: {this.Bulstat}; Number of employees: {this.Employees.Count}");
        }
    }
}
