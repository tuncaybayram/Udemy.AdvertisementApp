using System.Collections.Generic;

namespace Udemy.AdvertisementApp.Entities
{
    public class MilitaryStatus : BaseEntity
    {
        public string Definition { get; set; }
        public List<AdvertisementUser> AdvertisementUsers { get; set; }
    }
}