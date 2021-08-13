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
            new Store { StoreName = "Store1", StoreNumber = 1002, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000},
            new Store { StoreName = "Store1", StoreNumber = 1003, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000},
            new Store { StoreName = "Store1", StoreNumber = 1004, Qtr1 = 1000, Qtr2 = 100, Qtr3 = 10, Qtr4 = 10000},
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
        // store name
        // store number
        // list of employees
        // array of retail sales per quarter(4)
        // get gas yearly
        // get gas current quarter
        // get retail yearly
        // gas array of quarters
        
    }
}
