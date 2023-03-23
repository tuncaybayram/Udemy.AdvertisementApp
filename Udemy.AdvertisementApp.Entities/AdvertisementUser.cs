using System;

namespace Udemy.AdvertisementApp.Entities
{
    public class AdvertisementUser : BaseEntity
    {
        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int AdvertisementUserStatusId { get; set; }
        public AdvertisementUserStatus AdvertisementUserStatus { get; set; }
        public int MilitaryStatusId { get; set; }
        public MilitaryStatus MilitaryStatus { get; set; }
        public DateTime? MilitaryStatusEndDate { get; set; }
        public int WorkExperience { get; set; }
        public string CvPath { get; set; }
       

    }
}