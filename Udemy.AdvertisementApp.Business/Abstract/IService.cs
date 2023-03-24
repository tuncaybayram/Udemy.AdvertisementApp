using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Common.Response.Abstract;
using Udemy.AdvertisementApp.Dtos.Interfaces;
using Udemy.AdvertisementApp.Dtos.ProvidedServiceDtos;

namespace Udemy.AdvertisementApp.Business.Abstract
{
    public interface IService<CreateDto, UpdateDto, ListDto> where CreateDto : class, IDto, new() where UpdateDto : class, IDto,new() where  ListDto :class, IDto, new()
    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        Task<IResponse<UpdateDto>> CreateAsync(UpdateDto dto);
        Task<IResponse<IDto>> GetByIdAsync<IDto>(int id);
        Task<IResponse> RemoveAsync(int id);
        Task<IResponse<List<ListDto>>> GetAllAsync();

    }
}
