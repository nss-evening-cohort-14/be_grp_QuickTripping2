using System.Collections.Generic;
using System.Linq;

namespace be_grp_QuikTrippin
{

    class StoreRepository
    {
     public   static List<Store> _store = new List<Store>
        {
            // static int StoreNumber = 10006;
            new Store {
                StoreName = "Store1",
                StoreNumber = 1001,
                GasQtr1 = 1000,
                GasQtr2 = 100,
                GasQtr3 = 10,
                GasQtr4 = 10000,
                RetailQtr1 = 1000,
                RetailQtr2 = 100,
                RetailQtr3 = 10,
                RetailQtr4 = 10000,
                SalesPerQuarter = new List<double> {1,2,3,4}, 
                DistrictID = 1000
                },
               
            new Store { StoreName = "Store3", StoreNumber = 1002, GasQtr1 = 1000, GasQtr2 = 100, GasQtr3 = 10, GasQtr4 = 10000, RetailQtr1 = 1000, RetailQtr2 = 100, RetailQtr3 = 10, RetailQtr4 = 10000, DistrictID = 1000},
            new Store { StoreName = "Store2", StoreNumber = 1003, GasQtr1 = 1000, GasQtr2 = 100, GasQtr3 = 10, GasQtr4 = 10000, RetailQtr1 = 1000, RetailQtr2 = 100, RetailQtr3 = 10, RetailQtr4 = 10000, DistrictID = 1000},
            new Store { StoreName = "Store4", StoreNumber = 1004, GasQtr1 = 1000, GasQtr2 = 100, GasQtr3 = 10, GasQtr4 = 10000, RetailQtr1 = 1000, RetailQtr2 = 100, RetailQtr3 = 10, RetailQtr4 = 10000, DistrictID = 1000},
            new Store { StoreName = "Store5", StoreNumber = 1005, GasQtr1 = 1000, GasQtr2 = 100, GasQtr3 = 10, GasQtr4 = 10000, RetailQtr1 = 1000, RetailQtr2 = 100, RetailQtr3 = 10, RetailQtr4 = 10000, DistrictID = 1000},
        };



        public List<Store> GetAll()
        {
            return _store;
        }

        public void AddStore(Store store)
        {
            _store.Add(store);
        }

        public void DeleteStore(int storeNumber)
        {
            var storeToRemove = _store.First(store => store.StoreNumber == storeNumber);
            _store.Remove(storeToRemove);
        }

        public bool FindStore(int storeNumber)
        {
            foreach (var store in _store)
            {
                if (store.StoreNumber == storeNumber)
                {
                    return true;
                }
            }



            //if (foundStore == null) return false;
            return false;
        }


        public void FindQuarterValue(int userQuarter)
        {
           
                //switch (userQuarter)
                //{
                //    case 1:
                //        var quarter1Report = _store.Any(x => x.Qtr1 == userQuarter);
                //        return quarter1Report;

                //    case 2:
                //        var quarter2Report = _store.Any(x => x.Qtr2 == userQuarter);
                //        return quarter2Report;

                //    case 3:
                //        var quarter3Report = _store.Any(x => x.Qtr3 == userQuarter);
                //        return quarter3Report;

                //    case 4:
                //        var quarter4Report = _store.Any(x => x.Qtr3 == userQuarter);
                //        return quarter4Report;
                //    default: return Console.WriteLine("Invalid Entry");

                //}
        }
        public void GetStoreQuarter(int storeNumber, int userQuarter)
        {
            //switch (userQuarter)
            //{
                //case 1:
                //    return Qtr1;
                //    break;
                //case 2:
                //    return Qtr2;
                //    break;
                //case 3:
                //    return Qtr3;
                //    break;
                //case 4:
                //    return Qtr4;
                //    break;

            //}
        }
    }












    class Store
    {
        //public static int StoreID = 1001;
        // store name
        public string StoreName { get; set; }
        // store number
        public int StoreNumber { get; set; }
        // list of employees
        //List<Employees> ListOfEmployees { get; set; } = new List<Employees>();

        // array of retail sales per quarter(4)
       // public Dictionary<int, List<Store>>();

        public List<double> SalesPerQuarter { get; set; } = new List<double>();

        public double GasQtr1 { get; set; }
        public double GasQtr2 { get; set; }
        public double GasQtr3 { get; set; }
        public double GasQtr4 { get; set; }

        public double RetailQtr1 { get; set; }
        public double RetailQtr2 { get; set; }
        public double RetailQtr3 { get; set; }
        public double RetailQtr4 { get; set; }

        public int DistrictID { get; set; }

       
        // get gas yearly
        // get gas current quarter
        // get retail yearly
        // gas array of quarters

    }
}
