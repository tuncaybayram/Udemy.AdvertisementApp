﻿using FluentValidation;
using Udemy.AdvertisementApp.Dtos;

namespace Udemy.AdvertisementApp.Business.ValidationRules.FluentValidation
{
    public class GenderUpdateDtoValidator : AbstractValidator<GenderUpdateDto>
    {

        public GenderUpdateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
            RuleFor(x=>x.Id).NotEmpty();

        }

    }
}
