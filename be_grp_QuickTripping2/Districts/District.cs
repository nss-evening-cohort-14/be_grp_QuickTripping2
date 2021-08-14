//using be_grp_QuickTripping2.Districts;
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
            public string DistrictName { get; set; }

            // DistrictNumber
            public int DistrictNumber { get; set; }
            // public static int DistrictNumber = 1;

            //  District Manager
            public string DistrictManager { get; set; }

            // list of stores
            //public List<Store> ListOfStores { get; set; }  = new List<Store>();

            // Add District
            public District(string districtname, int districtNumber, string districtManager)
            {
                DistrictName = districtname;
                DistrictNumber++;
                DistrictManager = districtManager;

            }

        internal void Add(District district)
        {
            throw new NotImplementedException();
        }

        // Method
        public string GetDistrictName()
        {

            return DistrictName;
        }

        // Method
        public int GetDistrictNumber()
            {
                return DistrictNumber;
            }



        }
    }
