using AutoMapper;
using FluentValidation;
using Udemy.AdvertisementApp.Business.Abstract;
using Udemy.AdvertisementApp.Business.Abstract.Services;
using Udemy.AdvertisementApp.DataAccess.UnitOfWork;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Concrete.Services
{
    public class AppUserManager : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>,IAppUserManager
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public AppUserManager(IMapper mapper, IValidator<AppUserCreateDto> createDtoValidator, IValidator<AppUserUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
        }
    }
}
