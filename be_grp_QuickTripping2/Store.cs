using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_grp_QuikTrippin
{
   
    class StoreRepository
    {
        static List<Store> _store = new List<Store>
        {
            new Store { 
                StoreName = "Store1", 
                StoreNumber = 1001, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000, SalesPerQuarter = new List<double> {1,2,3,4} },
            new Store { StoreName = "Store1", StoreNumber = 1001, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000},
            new Store { StoreName = "Store1", StoreNumber = 1001, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000},
            new Store { StoreName = "Store1", StoreNumber = 1001, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000},
            new Store { StoreName = "Store1", StoreNumber = 1001, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000},
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
    }
    
    
    
    
    
    
    
    
    
    
    
    
    class Store
    {
        public static int storeID = 1001;
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
        // get gas yearly
        // get gas current quarter
        // get retail yearly
        // gas array of quarters

    }
}
