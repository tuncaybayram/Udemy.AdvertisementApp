﻿using Udemy.AdvertisementApp.Dtos.Interfaces;

namespace Udemy.AdvertisementApp.Dtos
{
    public class GenderListDto: IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
