using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_grp_QuikTrippin
{

    class StoreRepository
    {
        public static List<Store> _store = new List<Store>
        {
            new Store {
                StoreName = "Store1",
                StoreNumber = 1001,
                GasQtr1 = 4532,
                GasQtr2 = 7686,
                GasQtr3 = 4535,
                GasQtr4 = 86969,
                RetailQtr1 = 1233,
                RetailQtr2 = 3456,
                RetailQtr3 = 5667,
                RetailQtr4 = 14454,
                SalesPerQuarter = new List<double> {1,2,3,4},
                DistrictID = 1
                },

            new Store { StoreName = "Store3", StoreNumber = 1002, GasQtr1 = 1234, GasQtr2 = 9876, GasQtr3 = 4321, GasQtr4 = 12345, RetailQtr1 = 3454, RetailQtr2 = 6997, RetailQtr3 = 3445, RetailQtr4 = 34342, DistrictID = 1000},
            new Store { StoreName = "Store2", StoreNumber = 1003, GasQtr1 = 2345, GasQtr2 = 7654, GasQtr3 = 5678, GasQtr4 = 34544, RetailQtr1 = 4354, RetailQtr2 = 6788, RetailQtr3 = 5655, RetailQtr4 = 43242, DistrictID = 1000},
            new Store { StoreName = "Store4", StoreNumber = 1004, GasQtr1 = 3456, GasQtr2 = 6543, GasQtr3 = 3498, GasQtr4 = 56778, RetailQtr1 = 6979, RetailQtr2 = 9876, RetailQtr3 = 7676, RetailQtr4 = 65765, DistrictID = 1000},
            new Store { StoreName = "Store5", StoreNumber = 1005, GasQtr1 = 6789, GasQtr2 = 2344, GasQtr3 = 5643, GasQtr4 = 96977, RetailQtr1 = 1987, RetailQtr2 = 2321, RetailQtr3 = 5454, RetailQtr4 = 76757, DistrictID = 1000},
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
            //  var foundStore = _store.First(store => store.StoreNumber == storeNumber);
            var foundIt = false;
            foreach (var store in _store)
            {
                if (store.StoreNumber == storeNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }


    class Store
    {

        public string StoreName { get; set; }

        public int StoreNumber { get; set; }

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
        
    }
}
