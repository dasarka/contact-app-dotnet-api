using AutoMapper;
using ContactApp.Controllers.Resources;
using ContactApp.Models;

namespace ContactApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resources
            CreateMap<Contact, ContactResource>();

            // API Resources to Domain
            CreateMap<ContactResource, Contact>();
        }

    }
}