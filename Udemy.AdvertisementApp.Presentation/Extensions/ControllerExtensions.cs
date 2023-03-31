﻿using Microsoft.AspNetCore.Mvc;
using Udemy.AdvertisementApp.Common.Response.Abstract;
using Udemy.AdvertisementApp.Common.Response.Concrete;

namespace Udemy.AdvertisementApp.Presentation.Extensions
{
    public static  class ControllerExtensions
    {
        public static IActionResult ResponseRedirectAction<T>(this Controller controller, IResponse<T> response,
            string actionName)
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();
            if (response.ResponseType == ResponseType.ValidationError)
            {
                foreach (var error in response.ValidationErrors)
                {
                    controller.ModelState.AddModelError(error.PropertyName,error.ErrorMessage);
                }
                return controller.View(response.ResultData);

            }
            return controller.RedirectToAction(actionName);

        }

        public static IActionResult ResponseView<T>(this Controller controller, IResponse<T> response)
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();
            return controller.View(response.ResultData);

        }

        public static IActionResult ResponseRedirectAction(this Controller controller, IResponse response,
            string actionName)
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();
            return controller.RedirectToAction(actionName);

        }
    }
}
