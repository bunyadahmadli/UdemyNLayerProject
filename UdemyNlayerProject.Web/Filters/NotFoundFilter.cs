﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UdemyNlayerProject.Web.DTOs;
using UdemyNlayerProject.Core.Service;

namespace UdemyNlayerProject.Web.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        private readonly ICategoryService _categoryService;

        public NotFoundFilter(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int) context.ActionArguments.Values.FirstOrDefault();
            var product = await _categoryService.GetByIdAsync(id);
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
