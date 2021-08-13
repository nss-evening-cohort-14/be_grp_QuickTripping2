using be_grp_QuikTrippin;
using System;
using System.Collections.Generic;

namespace be_grp_QuickTripping2
{

  class Program
  {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Trip");
            
            var storeRepo = new StoreRepository();
            var storeRepo2 = new StoreRepository();
            //var districtRepo = new DistrictRepository();
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
                    // print menu
                    userEntry = GetMenuChoice();
                    break;
                case 3:
                    // Add New Employee
                    // print menu
                    userEntry = GetMenuChoice();
                    break;
                case 4:
                    // Add a Store/District
                    storeRepo2.AddStore(new Store { StoreName = "Chesty", StoreNumber = 1775, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000 } );


                    // print menu
                    userEntry = GetMenuChoice();
                    break;
                case 5:
                    // exiting program if menu choice is 5
                    return;
                default:
                    break;
            }
        }

        public static Int32 GetMenuChoice()
        {
            var userMenuChoice = "";
            var userChoice = 0;
            Console.WriteLine("Please enter a menu choice");
            userMenuChoice = Console.ReadLine();

            while (!Int32.TryParse(userMenuChoice, out userChoice))
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
            Console.WriteLine("4. Add a Store/District");
            Console.WriteLine("5. Exit");
        }
        //  Console.WriteLine("");

        public static void EnterDistrictSales()
        {

        }

        // District Menu
    //    public static void PrintDistrictMenu()
    //    {
    //        Console.WriteLine("District Menu");
    //        var allDistricts = districtRepo.GetAll();
    //        foreach (var district in allDistricts)
    //        {
    //            Console.WriteLine($"District #: {district.DistrictNumber} \t District Name: {district.DistrictName}");
    //        }
    //Console.WriteLine("1. District Stores");
    //        Console.WriteLine("2. Remove District");
    //        Console.WriteLine("3. Add District Manager");
    //        Console.WriteLine("4. Remove District Manager");
    //        Console.WriteLine("5. Exit");
    //    }




    }
}
