using be_grp_QuickTripping2.Districts;
using be_grp_QuikTrippin;
using System;
using System.Collections.Generic;
using be_grp_QuikTrippin.Districts;
using be_grp_QuikTrippin.DistrictClasses;

namespace be_grp_QuickTripping2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Quick Trip");

      var storeRepo = new StoreRepository();
      var districts = new DistrictRepository();
      var employees = new EmployeeRepostory();
      var userEntry = 0;
      // print menu
      PrintMenuChoice();
      userEntry = GetMenuChoice();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Trip");
            
            var storeRepo = new StoreRepository();
            var districtRepo = new DistrictRepository();
            
            var userEntry = 0;
            // print menu
            PrintMenuChoice();
            userEntry = GetMenuChoice();

      switch (userEntry)
      {
        case 1:
          // enter district sales
          // print menu
          userEntry = GetMenuChoice();
          break;
        case 2:
          // generate district report

          //var districts = new DistrictRepository();

          var districtReport = new DistrictReport();

          var districtsList = districts.GetAll();
          var storeList = storeRepo.GetAll();
          var employeeList = employees.GetAll();

          districtReport.PrintDistrictSalesReport(districtsList, storeList, employeeList);


          // print menu
          userEntry = GetMenuChoice();
          break;
        case 3:
          // Add New Employee
          // print menu
          userEntry = GetMenuChoice();
          break;
        case 4:
          //Add a Store/District
          storeRepo.AddStore(new Store { StoreName = "Store7", StoreNumber = 1007, GasQtr1 = 1000, GasQtr2 = 100, GasQtr3 = 10, GasQtr4 = 10000, RetailQtr1 = 1000, RetailQtr2 = 100, RetailQtr3 = 10, RetailQtr4 = 10000, DistrictID = 1 });

          Console.WriteLine($"This is the value for Quarter ");
          PrintStoreMenu(storeRepo);

          NewStoreMenu(storeRepo);

                    // print menu
                    userEntry = GetMenuChoice();
                    break;
                case 5:
                    PrintDistrictMenu(districtRepo);
                    //districtRepo.AddDistrict(new District { DistrictTitles.Name, DistrictNumber )
                    // print menu
                    userEntry = GetMenuChoice();
                    break;
                case 6:
                    // exiting program if menu choice is 6
                    return;
                default:
                    break;
            }
        }

    public static void NewStoreMenu(StoreRepository storeRepo)
    {
      var userChoice = CheckingValue("Would you like to make a new store? \nPlease Enter 1 for Yes. \nPlease Enter 2 for No.");
      while (userChoice == 1)
      {
        AddingNewStore(storeRepo);
        userChoice = CheckingValue("Would you like to make a new store? \nPlease Enter 1 for Yes. \nPlease Enter 2 for No.");
      }


      // okay, goodbye


    }





    public static void AddingNewStore(StoreRepository storeRepo)
    {
      var storeNumberInput = CheckingValue("Enter a store number:");
      while (storeRepo.FindStore(storeNumberInput))
      {
        storeNumberInput = CheckingValue("That store number already exists, please enter a new store number.");
      }
      var gasQuarter1 = CheckingValue("Enter sales for Gas Quarter 1:");
      var gasQuarter2 = CheckingValue("Enter sales for Gas Quarter 2:");
      var gasQuarter3 = CheckingValue("Enter sales for Gas Quarter 3:");
      var gasQuarter4 = CheckingValue("Enter sales for Gas Quarter 4:");

      Console.WriteLine($"Yearly Gas Sales for {storeNumberInput}");
      Console.WriteLine(gasQuarter1 + gasQuarter2 + gasQuarter3 + gasQuarter4);

      Console.WriteLine($"Enter Retail sales for {storeNumberInput}");
      var retailYearly = Int32.Parse(Console.ReadLine());
      var retailQuarter1 = CheckingValue("Enter sales for retail Quarter 1:");
      var retailQuarter2 = CheckingValue("Enter sales for retail Quarter 2:");
      var retailQuarter3 = CheckingValue("Enter sales for retail Quarter 3:");
      var retailQuarter4 = CheckingValue("Enter sales for retail Quarter 4:");

      Console.WriteLine($"Yearly Retail Sales for {storeNumberInput}");
      Console.WriteLine(retailQuarter1 + retailQuarter2 + retailQuarter3 + retailQuarter4);
      storeRepo.AddStore(new Store
      {
        StoreName = "Store1",
        StoreNumber = storeNumberInput,
        GasQtr1 = gasQuarter1,
        GasQtr2 = gasQuarter2,
        GasQtr3 = gasQuarter3,
        GasQtr4 = gasQuarter4,
        RetailQtr1 = retailQuarter1,
        RetailQtr2 = retailQuarter2,
        RetailQtr3 = retailQuarter3,
        RetailQtr4 = retailQuarter4,
        DistrictID = 1000,
      });
    }
    public static Int32 CheckingValue(string message)
    {
      var checkValue = string.Empty;
      var userChoice = 0;
      Console.WriteLine($"{message}");
      checkValue = Console.ReadLine();

      while (!Int32.TryParse(checkValue, out userChoice) || userChoice < 1)
      {

        Console.WriteLine($"{message}");
        checkValue = Console.ReadLine();
      }
      return userChoice;
    }

    public static Int32 GetMenuChoice()
    {
      var userMenuChoice = "";
      var userChoice = 0;
      Console.WriteLine("Please enter a menu choice");
      userMenuChoice = Console.ReadLine();

      while (!Int32.TryParse(userMenuChoice, out userChoice) || (userChoice > 5 && userChoice < 1))
      {
        PrintMenuChoice();
        Console.WriteLine("Please enter a menu choice");
        userMenuChoice = Console.ReadLine();
      }
      return userChoice;
    }

        public static void PrintMenuChoice()
        {
            Console.WriteLine("1. Enter District Sales");
            Console.WriteLine("2. Generate District Report");
            Console.WriteLine("3. Add New Employee");
            Console.WriteLine("4. Add a Store");
            Console.WriteLine("5. Add District");
            Console.WriteLine("6. Exit");
        }
        //  Console.WriteLine("");

    public static void EnterDistrictSales()
    {

    }

    public static void PrintStoreMenu(StoreRepository storeRepo)
    {
      Console.WriteLine("Store Menu:");
      var allTheStores = storeRepo.GetAll();
      foreach (var store in allTheStores)
      {
        Console.WriteLine($"Store Number: {store.StoreNumber} \t Store Name:{store.StoreName}");
      }

    }

        // District Menu
            public static void PrintDistrictMenu(DistrictRepository districtRepo)
        {
            Console.WriteLine("District Menu");
            var allDistricts = districtRepo.GetAll();
            foreach (var district in allDistricts)
            {
                Console.WriteLine($"District #: {district.DistrictNumber} \t District Name: {district.Name.ToString()}");
            }
            Console.WriteLine("1. District Stores");
            Console.WriteLine("2. Remove District");
            Console.WriteLine("3. Add District Manager");
            Console.WriteLine("4. Remove District Manager");
            Console.WriteLine("5. Exit");
        }




  }











}
