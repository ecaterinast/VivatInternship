using VivatInternship.Backend.Data;
using AutoMapper;
using VivatInternship.Backend.Models;
using VivatInternship.Backend.Models.User;

namespace VivatInternship.Backend.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // User -> AuthenticateResponse
            CreateMap<User, UserModel>();

            // RegisterRequest -> User
            CreateMap<RegisterModel, User>();

            // UpdateRequest -> User
            CreateMap<UpdateModel, User>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));
        }
    }
}
