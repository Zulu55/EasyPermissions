﻿using EasyPermissions.Backend.UnitsOfWork.Interfaces;
using EasyPermissions.Shared.DTOs;
using EasyPermissions.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EasyPermissions.Backend.Controllers
{
   [ApiController]
    [Route("api/[controller]")]
    public class CategoryNoticesController : GenericController<CategoryNotice>
    {
        private readonly ICategoryNoticesUnitOfWork _categoryNoticesUnitOfWork;

        public CategoryNoticesController(IGenericUnitOfWork<CategoryNotice> unitOfWork, ICategoryNoticesUnitOfWork categoryNoticesUnitOfWork) : base(unitOfWork)
        {
            _categoryNoticesUnitOfWork = categoryNoticesUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync(PaginationDTO pagination)
        {
            var response = await _categoryNoticesUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("totalPages")]
        public override async Task<IActionResult> GetPagesAsync([FromQuery] PaginationDTO pagination)
        {
            var action = await _categoryNoticesUnitOfWork.GetTotalPagesAsync(pagination);
            if (action.WasSuccess)
            {
                return Ok(action.Result);
            }
            return BadRequest();
        }
    }
}