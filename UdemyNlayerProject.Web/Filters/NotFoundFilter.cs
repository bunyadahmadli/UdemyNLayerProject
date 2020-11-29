using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UdemyNlayerProject.Web.DTOs;
using UdemyNlayerProject.Web.ApiService;

namespace UdemyNlayerProject.Web.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        private readonly CategoryApiService _categoryApiService;

        public NotFoundFilter( CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int) context.ActionArguments.Values.FirstOrDefault();
            var product = await _categoryApiService.GetByIdAsync(id);
            if (product != null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
               
                errorDto.Errors.Add($"Id'si {id} kategori veritabanında bulanamadı!");
                context.Result =new RedirectToActionResult("Error","Home",errorDto);
            }
        }
    }
}
