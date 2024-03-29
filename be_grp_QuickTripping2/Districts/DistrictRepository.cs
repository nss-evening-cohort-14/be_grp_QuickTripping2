﻿using be_grp_QuikTrippin;
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
            new District(DistrictTitles.South, 1, EmployeeTitles.DistrictManager, "Silent Bob", 1001),
            new District(DistrictTitles.SouthEast, 2, EmployeeTitles.DistrictManager, "Karen", 1003),
            new District(DistrictTitles.NorthEast, 3, EmployeeTitles.DistrictManager, "Saul", 1004)
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

        public void Delete(DistrictTitles districtname)
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

        // private static readonly Store _store;
    }
}
