using be_grp_QuikTrippin;
using System;

namespace be_grp_QuickTripping2
{
<<<<<<< HEAD
  class Program
  {
    static void Main(string[] args)
    {
       Console.WriteLine("Quick Trip");

      var userEntry = 0;
      // print menu
      PrintMenuChoice();
      GetMenuChoice();
=======
    class Program
    {
        static void Main(string[] args)
        {
            var storeRepo = new StoreRepository();
            var userEntry = 0;
            // print menu
            PrintMenuChoice();
            userEntry = GetMenuChoice();
>>>>>>> 2ec70ddf98e661a7403a198aaf18286a61079edd

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
                    storeRepo.AddStore(new Store { StoreName = "Store1", StoreNumber = 1001, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000 } );
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




    }
}
