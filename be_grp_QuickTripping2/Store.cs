using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Qtr1 = 1000,
                Qtr2 = 100,
                Qtr3 = 10,
                Qtr4 = 10000,
                SalesPerQuarter = new List<double> {1,2,3,4}, 
                DistrictID = 1000
                },
               
            new Store { StoreName = "Store3", StoreNumber = 1002, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000, DistrictID = 1000},
            new Store { StoreName = "Store2", StoreNumber = 1003, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000, DistrictID = 1000},
            new Store { StoreName = "Store4", StoreNumber = 1004, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000, DistrictID = 1000},
            new Store { StoreName = "Store5", StoreNumber = 1005, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000, DistrictID = 1000},
        };

        public List<Store> GetAll()
        {
            return _store;
        }

        public void AddStore(Store store)
        {
            _store.Add(store);
        }

        public void DeleteStore(double storeNumber)
        {
            var storeToRemove = _store.First(store => store.StoreNumber == storeNumber);
            _store.Remove(storeToRemove);
        }

        //public void FindQuarterValue(int userQuarter)
        //{
        //    switch (userQuarter)
        //    {
        //        case 1:
        //            return Qtr1;
        //            break;
        //        case 2:
        //            return Qtr2;
        //            break;
        //        case 3:
        //            return Qtr3;
        //            break;
        //        case 4:
        //            return Qtr4;
        //            break;

        //    }
        //}
        public void GetStoreQuarter(int storeID, int userQuarter)
        {
            //switch (userQuarter)
            //{
            //    case 1:
            //        return Qtr1;
            //        break;
            //    case 2:
            //        return Qtr2;
            //        break;
            //    case 3:
            //        return Qtr3;
            //        break;
            //    case 4:
            //        return Qtr4;
            //        break;

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
        public List<double> SalesPerQuarter { get; set; } = new List<double>();
        public double Qtr1 { get; set; }
        public double Qtr2 { get; set; }
        public double Qtr3 { get; set; }
        public double Qtr4 { get; set; }

        public int DistrictID { get; set; }

       
        // get gas yearly
        // get gas current quarter
        // get retail yearly
        // gas array of quarters

    }
}
