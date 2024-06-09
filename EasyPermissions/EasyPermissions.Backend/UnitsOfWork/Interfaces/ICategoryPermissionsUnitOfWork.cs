﻿using EasyPermissions.Shared.DTOs;
using EasyPermissions.Shared.Entities;
using EasyPermissions.Shared.Responses;

namespace EasyPermissions.Backend.UnitsOfWork.Interfaces
{
    public interface ICategoryPermissionsUnitOfWork
    {
        Task<ActionResponse<CategoryPermission>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<CategoryPermission>>> GetAsync();

        Task<ActionResponse<IEnumerable<CategoryPermission>>> GetAsync(PaginationDTO pagination);

        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);

        Task<IEnumerable<CategoryPermission>> GetComboAsync(int typePermissionId);

    }
}