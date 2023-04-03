using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Abstract.Services
{
    public interface IAppUserManager : IService<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>
    {
       
    }
}
