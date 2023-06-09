﻿using Udemy.AdvertisementApp.Dtos.Interfaces;

namespace Udemy.AdvertisementApp.Dtos
{
    public class AppUserListDto : IDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
    }
}
