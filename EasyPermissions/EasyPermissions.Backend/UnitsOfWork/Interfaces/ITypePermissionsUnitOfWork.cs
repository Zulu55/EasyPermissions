﻿using EasyPermissions.Shared.DTOs;
using EasyPermissions.Shared.Entities;
using EasyPermissions.Shared.Responses;

namespace EasyPermissions.Backend.UnitsOfWork.Interfaces
{
   public interface ITypePermissionsUnitOfWork
    {
        Task<ActionResponse<TypePermission>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<TypePermission>>> GetAsync();

        Task<ActionResponse<IEnumerable<TypePermission>>> GetAsync(PaginationDTO pagination);

        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
