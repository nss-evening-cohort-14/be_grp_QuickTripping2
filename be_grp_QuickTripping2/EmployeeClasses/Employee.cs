using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_grp_QuikTrippin.DistrictClasses
{
    class EmployeeRepostory
    {
        static List<Employee> _employees = new List<Employee>()
        {
            new Employee("Sara Schoonover", 1001, EmployeeTitles.GeneralManager),
            new Employee("Martin Sisk", 1001, EmployeeTitles.Clerk),
            new Employee("Hunter Juneau", 1001, EmployeeTitles.Clerk),
            new Employee("Juan Davila", 1001, EmployeeTitles.AssistantManager)
        };
    }
    class Employee
    {
        public string Name { get; }
        public int StoreNumber { get; }
        public EmployeeTitles Title { get; }

        public Employee(string name, int storeNumber, EmployeeTitles title)
        {
            Name = name;
            StoreNumber = storeNumber;
            Title = title;
        }
    }
}
