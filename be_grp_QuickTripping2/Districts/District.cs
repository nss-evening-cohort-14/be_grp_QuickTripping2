//using be_grp_QuickTripping2.Districts;
using be_grp_QuickTripping2.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_grp_QuikTrippin.Districts
    {
        // District Class
        class District
        {
            // District Name
            public DistrictTitles Name { get; }

            // DistrictNumber
            public int DistrictNumber { get; set; }
        // public static int DistrictNumber = 1;

        //  District Manager
        public EmployeeTitles Title { get; }
        public string DistrictManager { get; set; }

            // list of stores
            public int StoreNumber { get; }
            //public List<Store> ListOfStores { get; set; }  = new List<Store>();

            // Add District
            public District(DistrictTitles districtname, int districtNumber, EmployeeTitles title, string districtManager, int storeNumber)
            {
                Name = districtname;
                DistrictNumber++;
                Title = title;
                DistrictManager = districtManager;
                StoreNumber = storeNumber;

            }

        // Method
        //public string Getdistrictname()
        //{
        //    return EmployeeTitles.Name;
        //}

        // Method
        public int GetDistrictNumber()
            {
                return DistrictNumber;
            }

        }
    }
