using be_grp_QuickTripping2.Districts;
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
                    storeRepo.AddStore(new Store { StoreName = "Store1", StoreNumber = 1001, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000, DistrictID = 1000} );
                    Console.WriteLine($"This is the value for Quarter ");
                    
                    PrintStoreMenu(storeRepo);

                    PrintDistrictMenu(districtRepo);
                    //districtRepo.AddDistrict(new District { DistrictTitles.Name, DistrictNumber )

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
            Console.WriteLine("4. Add a Store/District");
            Console.WriteLine("5. Exit");
        }
        //  Console.WriteLine("");

        public static void EnterDistrictSales()
        {

        }

        public static void PrintStoreMenu(StoreRepository storeRepo)
        {
            Console.WriteLine("Store Menu:");
            var allTheStores = storeRepo.GetAll();
                foreach(var store in allTheStores)
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
