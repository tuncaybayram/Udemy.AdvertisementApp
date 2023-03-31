﻿using System;
using Udemy.AdvertisementApp.Dtos.Interfaces;

namespace Udemy.AdvertisementApp.Dtos
{
    public class AdvertisementListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public bool Status { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}