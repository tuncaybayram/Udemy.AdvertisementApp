﻿using System.Collections.Generic;

namespace Udemy.AdvertisementApp.Entities
{
    public class AppUser : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public List<AppUserRole> AppUserRoles{ get; set; }
        public List<AdvertisementUser> AdvertisementUsers { get; set; }
    }
}