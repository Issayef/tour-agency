using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_agency
{
    
    class Country
    {
        public string countryname;
    }
    class City
    {
        public string cityname;
    }
    class Hotel
    {
        public string hotelname;
        public string information;
        public int price;
    }
    class Excursion
    {
        public string exname;
        public int exprice;
        public string exdescription;
        public int extime;
    }
    class Manager
    {
        public string name;
    }
    class Tourist
    {
        public string touristname;
    }
    class Status
    {
        public string status;
    }
    class CountryList
    {
        public static List<Country> countries;

        public CountryList()
        {
            if (countries == null)
            {
                countries = new List<Country>();
            }
        }
        public void adde(Country coun)
        {
            countries.Add(coun);
        }
        public List<Country> Countries
        {
            get { return countries; }
        }
    }
    class CityList
    {
        public static List<City> cities;

        public CityList()
        {
            if (cities == null)
            {
                cities = new List<City>();
            }
        }
        public void adde(City cit)
        {
            cities.Add(cit);
        }
        public List<City> Cities
        {
            get { return cities; }
        }
    }
    class HotelList
    {
        public static List<Hotel> hotels;

        public HotelList()
        {
            if (hotels == null)
            {
                hotels = new List<Hotel>();
            }
        }
        public void adde(Hotel hot)
        {
            hotels.Add(hot);
        }
        public List<Hotel> Hotels
        {
            get { return hotels; }
        }
    }
    class ExcursionList
    {
        public static List<Excursion> excur;

        public ExcursionList()
        {
            if (excur == null)
            {
                excur = new List<Excursion>();
            }
        }
        public void adde(Excursion ex)
        {
            excur.Add(ex);
        }
        public List<Excursion> Hotels
        {
            get { return excur; }
        }
    }
   
}
