﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UdemyNlayerProject.Web.ApiService;
using UdemyNlayerProject.Web.DTOs;
using UdemyNlayerProject.Web.Filters;

namespace UdemyNlayerProject.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryApiService _categoryApiService;
        private readonly IMapper _mapper;

        public CategoriesController( IMapper mapper, CategoryApiService categoryApiService)
        {
            
            _mapper = mapper;
            _categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryApiService.GetAllAsync();

            return View(_mapper.Map <IEnumerable<CategoryDto>>(categories));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            await _categoryApiService.AddAsync(categoryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryApiService.GetByIdAsync(id);
            return View(_mapper.Map<CategoryDto>(category));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
          await  _categoryApiService.UpdateAsync(categoryDto);
            return RedirectToAction("Index");
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        public async Task<IActionResult> Delete(int id)
        {
         await   _categoryApiService.RemoveAsync(id);
            return RedirectToAction("Index");

        }
    }
}
