using be_grp_QuikTrippin;
using be_grp_QuikTrippin.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_grp_QuickTripping2.Districts
{
    class DistrictRepository
    {
        static List<District> _district = new List<District>() 
        {
            new District("South", 1, EmployeeTitles.DistrictManager, "Silent Bob"),
            new District("SouthEast", 2, EmployeeTitles.DistrictManager, "Karen"),
            new District("NorthEast", 3, EmployeeTitles.DistrictManager, "Saul")
        };


        // private static readonly Store _store;
        public List<District> GetAll()
        {
            return _district;
        }

        static void AddDistrict(District district)
        {
            _district.Add(district);
        }

        public void Delete(string districtname)
        {
            var removeDistrict = _district.First
                (district => district.DistrictName == districtname);

            _district.Remove(removeDistrict);
        }

        //static List<District> _district = new List<District>
        //{
        //  new District
        //    //{
        //    //    DistrictName = "SE",
        //    //    DistrictNumber = 1,
        //    //    DistrictManager = "Bob",
        //    //    //ListOfStores = new List<Store> {_store}
        //    //    //ListOfStores = StoreRepository._store
        //    //}
        //};

        // private static readonly Store _store;
    }
}
