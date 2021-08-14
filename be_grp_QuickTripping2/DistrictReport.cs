
using be_grp_QuikTrippin;
using be_grp_QuikTrippin.DistrictClasses;
using be_grp_QuikTrippin.Districts;
using System;
using System.Collections.Generic;

namespace be_grp_QuickTripping2
{
  class DistrictReport
  {

    public void PrintDistrictSalesReport(List<District> districts,
                                         List<Store> storeList,
                                         List<Employee> employees)
    {

      foreach (var district in districts)
      {

        FormatDistrictReport(district);

        foreach (var store in storeList)
        {
          if (store.DistrictID == district.DistrictNumber)
          {
            FormatStoreReport(store, employees);
          }
        }

      }

    }

    void FormatDistrictReport(District district)
    {
      Console.WriteLine($"District: {district.GetDistrictName()}");
      Console.WriteLine($"District #: {district.GetDistrictNumber()}");
      Console.WriteLine($"Manager: {district.DistrictManager}");
      Console.WriteLine("\n\n");
    }

    void FormatStoreReport(Store store,
                           List<Employee> employees)
    {
      Console.WriteLine($"Store: {store.StoreName}");
      Console.WriteLine($"Store #: {store.StoreNumber}");

      var employeeCount = 1;

      foreach (var employee in employees)
      {
        if (employee.StoreNumber == store.StoreNumber)
        {
          Console.WriteLine($"{employeeCount++}.\tEmloyee title: {employee.Title}");
          Console.WriteLine($"\t\t:{employee.Name}:");
          Console.WriteLine($"\t\t\t:Retail Sales: :");
        }
      }

      Console.WriteLine($"Gas yearly: {store.GasQtr1 + store.GasQtr2 + store.GasQtr3 + store.GasQtr4}");
      Console.WriteLine($"Gas Current Quarter: {store.GasQtr1}");
      Console.WriteLine($"Retail yearly: {store.RetailQtr1 + store.RetailQtr2 + store.RetailQtr3 + store.RetailQtr4}");
      Console.WriteLine($"Gas Current Quarter: {store.RetailQtr1}");

      Console.WriteLine("\n\n");
    }








  }
}
