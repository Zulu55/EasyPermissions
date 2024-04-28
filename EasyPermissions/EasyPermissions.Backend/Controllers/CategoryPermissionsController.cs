﻿using EasyPermissions.Backend.UnitsOfWork.Interfaces;
using EasyPermissions.Shared.DTOs;
using EasyPermissions.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EasyPermissions.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryPermissionsController : GenericController<CategoryPermission>
    {
        private readonly ICategoryPermissionsUnitOfWork _categoryPermissionsUnitOfWork;

        public CategoryPermissionsController(IGenericUnitOfWork<CategoryPermission> unitOfWork, ICategoryPermissionsUnitOfWork _categoryPermissionsUnitOfWork) : base(unitOfWork)
        {
            _categoryPermissionsUnitOfWork = _categoryPermissionsUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync(PaginationDTO pagination)
        {
            var response = await _categoryPermissionsUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("totalPages")]
        public override async Task<IActionResult> GetPagesAsync([FromQuery] PaginationDTO pagination)
        {
            var action = await _categoryPermissionsUnitOfWork.GetTotalPagesAsync(pagination);
            if (action.WasSuccess)
            {
                return Ok(action.Result);
            }
            return BadRequest();
        }
    }
}