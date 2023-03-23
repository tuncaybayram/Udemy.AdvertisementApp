using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Common.Response.Abstract;

namespace Udemy.AdvertisementApp.Common.Response.Concrete
{
    public class Response<T> : Response,IResponse<T>
    {
        public T ResultData { get; set; }
        public List<CustomValidationError> ValidationErrors { get; set; }
        public Response(ResponseType responseType, string message) : base(responseType, message)
        {

        }

        public Response(ResponseType responseType, T resultData) : base(responseType)
        {
            ResultData = resultData;
        }
        public Response(T resultData, List<CustomValidationError> errors) : base(ResponseType.ValidationError)
        {
            ResultData = resultData;
            ValidationErrors = errors;
        }

    }
}
