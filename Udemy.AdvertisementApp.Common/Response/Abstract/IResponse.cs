using Udemy.AdvertisementApp.Common.Response.Concrete;

namespace Udemy.AdvertisementApp.Common.Response.Abstract
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }
    }
}