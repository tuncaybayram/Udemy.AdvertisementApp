using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Abstract;
using Udemy.AdvertisementApp.Common.Response.Abstract;
using Udemy.AdvertisementApp.Dtos.Interfaces;

namespace Udemy.AdvertisementApp.Business.Concrete
{
    public class Service<CreateDto,UpdateDto,ListDto> : IService<CreateDto,UpdateDto,ListDto> where CreateDto : class, IDto, new() where UpdateDto : class, IDto, new() where ListDto : class, IDto, new()
    {


        public Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<UpdateDto>> CreateAsync(UpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<IDto1>> GetByIdAsync<IDto1>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<List<ListDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
