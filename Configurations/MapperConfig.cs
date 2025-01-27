using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // setups a autoconfiguration for a country and createcountrydto
            /*
             * Can save us a lot of time with configuration
             */
            CreateMap<Country, CreateCountryDto>().ReverseMap();
        }
    }
}
