
namespace TheRealEstateCompany.Company
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TheRealEstateCompany.CompanyClasses;

    public static class CompanyCreator
    {
        public static MainCompany Create()
        {
            Console.Write("Enter your company name... ");
            string name = Console.ReadLine();
            Console.Write("Enter your bulstat... ");
            string bulstat = Console.ReadLine();
            Console.Write("Enter the owner first name...");
            string ownerFirstName = Console.ReadLine();
            Console.Write("Enter the owner last name...");
            string ownerLastName = Console.ReadLine();
            Console.Write("Enter owner years of experience...");
            double ownerYearsOfExperience = double.Parse(Console.ReadLine());
            Console.WriteLine(ownerYearsOfExperience);

            Employee owner = new Employee()
            {
                FirstName = ownerFirstName,
                LastName = ownerLastName,
                ExperienceInYears = ownerYearsOfExperience,
                Position = Position.Owner
            };
           
            MainCompany company =  new MainCompany()
            {
                Name = name,
                Bulstat = bulstat,
                Owner = owner
            };

            company.Employees.Add(owner);

            return company;
            
        }

        public static List<Employee> SeedEmployees()
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < 5; i++)
            {
                employees.Add(new Employee()
                {
                    FirstName = $"Employee{i}",
                    LastName = $"EmployeeLastName{i}",
                    ExperienceInYears = i,
                    Position = (Position)i
                });
            }

            return employees;
        }
    }
}
