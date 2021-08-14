using System.Collections.Generic;

namespace be_grp_QuikTrippin
{
    class EmployeeRepository
    {
        public static List<Employee> _employees = new List<Employee>()
        {
            new Employee("Sara Schoonover", 1001, EmployeeTitles.GeneralManager, 3408),
            new Employee("Martin Sisk", 1001, EmployeeTitles.Clerk, 1044),
            new Employee("Hunter Juneau", 1001, EmployeeTitles.Clerk, 1668),
            new Employee("Juan Davila", 1001, EmployeeTitles.AssistantManager, 5711)
        };

        public bool FindEmployee(string employeeName)
        {
            foreach (var employee in _employees)
            {
                if (employee.Name == employeeName)
                {
                    return true;
                }
            }

            return false;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
    class Employee
    {
        public string Name { get; }
        public int StoreNumber { get; }
        public EmployeeTitles Title { get; }
        public int RetailSales { get; set; }

        public Employee(string name, int storeNumber, EmployeeTitles title, int sales)
        {
            Name = name;
            StoreNumber = storeNumber;
            Title = title;
            RetailSales = sales;
        }
    }
}
