namespace TheRealEstateCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee
    {
        private string firstName;
        private string lastName;
        private double experienceInYears;

        public Employee()
        {

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("First name is required!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last name is required!");
                }
                this.lastName = value;
            }
        }

        public Position Position { get; set; }

        public double ExperienceInYears
        {
            get
            {
                return this.experienceInYears;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Experience can not be a negative number!");
                }
                this.experienceInYears = value;
            }
        }
    }
}
