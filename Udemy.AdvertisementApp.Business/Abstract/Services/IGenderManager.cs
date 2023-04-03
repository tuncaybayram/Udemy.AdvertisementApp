using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Abstract.Services
{
    public interface IGenderManager : IService<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>
    {

    }
}
