﻿using System;
using System.Collections.Generic;

namespace Udemy.AdvertisementApp.Entities
{
    public class Advertisement:BaseEntity
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<AdvertisementUser> AdvertisementUsers{ get; set; }

    }
}