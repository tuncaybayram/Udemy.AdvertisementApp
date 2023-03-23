using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Common.Response.Concrete;

namespace Udemy.AdvertisementApp.Common.Response.Abstract
{
    public interface IResponse<T> : IResponse
    {
        public T ResultData { get; set; }
        public List<CustomValidationError> ValidationErrors { get; set; }
    }
}
