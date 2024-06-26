﻿using AsilMedia.Application.DataTransferObject;
using AsilMedia.Application.Services.Roles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asilmedia.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
            => _roleService = roleService;

        [HttpPost]
        public async Task<IActionResult> PostRoleAsync(RoleDTO roleDTO)
        {
            var role = await _roleService.InsertAsync(roleDTO);

            return Ok(role);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoleAsync()
        {
            return Ok(await _roleService.SelectAllAsync());
        }
    }
}
