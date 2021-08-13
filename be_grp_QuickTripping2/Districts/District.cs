using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_grp_QuikTrippin
{
    class DistrictRepository
    {
        static List<District> _district = new List<District>
        {
            new District
            {
                DistrictName = "SE",
                //DistrictNumber = 1,
                DistrictManager = "Bob",
                //ListOfStores = new List<Store> {_store}
                //ListOfStores = StoreRepository._store
            }

        };

        //   // private static readonly Store _store;

        public List<District> GetAll()
        {
            return _district;
        }

        public void AddDistrict(District district)
        {
            _district.Add(district);
        }

        public void Delete(District district.DistrictName)
        {
            var removeDistrict = _district.First
                (district => district.DistrictName);

            _district.Remove(removeDistrict);
        }




        public class District
        {
            // district name
            public string DistrictName { get; set; } = "DistrictOne";

            // list of stores
            //public List<Store> ListOfStores { get; set; }  = new List<Store>();

            // add store/district
            public static int DistrictNumber = 1;


            // add district manager
            public string DistrictManager { get; set; } = "Bob";

            public District(string districtName, string districtManager)
            {
                DistrictName = districtName;
                DistrictNumber++;
                DistrictManager = districtManager;

            }

            // Method
            public string GetDistrictName()
            {

                return DistrictName;
            }

            public int GetDistrictNumber()
            {
                return DistrictNumber;
            }





            // I made changes
        }
    }
}
