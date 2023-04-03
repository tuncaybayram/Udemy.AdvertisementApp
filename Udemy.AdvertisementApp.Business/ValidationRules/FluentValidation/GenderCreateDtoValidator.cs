using FluentValidation;
using Udemy.AdvertisementApp.Dtos;

namespace Udemy.AdvertisementApp.Business.ValidationRules.FluentValidation
{
    public class GenderCreateDtoValidator : AbstractValidator<GenderCreateDto>
    {

        public GenderCreateDtoValidator()
        {
            
        }

    }
}
