namespace TheRealEstateCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TheRealEstateCompany.Company;
    using TheRealEstateCompany.CompanyClasses;

    public class StartUp
    {
        public static void Main()
        {
            MainCompany company = CompanyCreator.Create();
            company.Employees = CompanyCreator.SeedEmployees();
            

        }
    }
}