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
            new District {DistrictName = "District1", DistrictNumber = 1, Qtr1 = 1000, Qtr2 = 2000, Qtr3 = 2000, Qtr4 = 1000 },
        };

        public List<District> GetAll()
        {
            return _district;
        }

        public void AddDistrict(District district)
        {
            _district.Add(district);
        }

    }



    class District
    {
        // district name
        public string DistrictName { get; set;}

        // list of stores
        //List<Stores> ListOfStores { get; set; } = new List<Stores>();

        // add store/district
        public string StoreName { get; set; }


        // add district manager

        public string DistrictManager { get; set; }
        ;
        // I made changes
    }
}
