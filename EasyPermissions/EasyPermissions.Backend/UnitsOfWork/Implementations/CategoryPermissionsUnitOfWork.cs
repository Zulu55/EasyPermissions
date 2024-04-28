﻿using EasyPermissions.Backend.Repositories.Interfaces;
using EasyPermissions.Backend.UnitsOfWork.Interfaces;
using EasyPermissions.Shared.DTOs;
using EasyPermissions.Shared.Entities;
using EasyPermissions.Shared.Responses;

namespace EasyPermissions.Backend.UnitsOfWork.Implementations
{
    public class CategoryPermissionsUnitOfWork : GenericUnitOfWork<CategoryPermission>, ICategoryPermissionsUnitOfWork
    {
        private readonly ICategoryPermissionsRepository _categoryPermissionsRepository;

        public CategoryPermissionsUnitOfWork(IGenericRepository<CategoryPermission> repository, ICategoryPermissionsRepository categoryPermissionsRepository) : base(repository)
        {
            _categoryPermissionsRepository = categoryPermissionsRepository;
        }

        public override async Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination) => await _categoryPermissionsRepository.GetTotalPagesAsync(pagination);

        public override async Task<ActionResponse<IEnumerable<CategoryPermission>>> GetAsync(PaginationDTO pagination) => await _categoryPermissionsRepository.GetAsync(pagination);
    }
}