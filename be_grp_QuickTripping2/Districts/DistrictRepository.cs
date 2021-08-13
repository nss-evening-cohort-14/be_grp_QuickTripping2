using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_grp_QuickTripping2.Districts
{
    class DistrictRepository
    {
        static List<District> _district = new List<District> 
        {
            new District(DistrictName, 1, "Bob"),
            new District(DistrictName, 2, "Karen"),
        };

        //public static object Districtname { get; private set; }

        // private static readonly Store _store;
        public List<District> GetAll()
        {
            return _district;
        }

        public void AddDistrict(District districtname)
        {
            _district.Add(district);
        }

        public void Delete(DistrictName districtname)
        {
            var removeDistrict = _district.First
                (district => district.Name == districtname);

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

        //public static object Districtname { get; private set; }

        // private static readonly Store _store;


    }
}
