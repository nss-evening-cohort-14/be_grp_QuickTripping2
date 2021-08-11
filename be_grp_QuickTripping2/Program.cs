using System;

namespace be_grp_QuickTripping2
{
  class Program
  {
        
    static void Main(string[] args)
    {
       Console.WriteLine("Quick Trip 2");

            var userEntry = 0;
      // print menu
      PrintMenuChoice();
      GetMenuChoice();

 switch (userEntry)
      {
        case 1:
          // enter district sales
          // print menu
          GetMenuChoice();
          break;
        case 2:
          // generate district report
          // print menu
          GetMenuChoice();
          break;
        case 3:
          // Add New Employee
          // print menu
          GetMenuChoice();
          break;
        case 4:
          // Add a Store/District
          // print menu
          GetMenuChoice();
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
