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

        // private static readonly Store _store;

        public List<District> GetAll()
        {
            return _district;
        }

        public void AddDistrict(District district)
        {
            _district.Add(district);
        }

        public void Delete(District district)
        {
            var removeDistrict = _district.First
                (district => district.DistrictName == name);

            _district.Remove(removeDistrict);
        }




        public class District
        {
            // District Name
            public DistrictName Name { get; set; }

            // DistrictNumber
            public int DistrictNumber { get; set; }
            // public static int DistrictNumber = 1;

            //  District Manager
            public string DistrictManager { get; set; }

            // list of stores
            //public List<Store> ListOfStores { get; set; }  = new List<Store>();

            // add store/district
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





        }
    }
}
