using AutoMapper;
using FluentValidation;
using Udemy.AdvertisementApp.Business.Abstract.Services;
using Udemy.AdvertisementApp.DataAccess.UnitOfWork;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Concrete.Services
{
    public class GenderManager : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>,IGenderManager
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public GenderManager(IMapper mapper, IValidator<GenderCreateDto> createDtoValidator, IValidator<GenderUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
        }
    }
}
