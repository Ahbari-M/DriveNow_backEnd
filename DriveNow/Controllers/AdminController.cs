﻿using DriveNow.Data;
using DriveNow.Dtos;
using DriveNow.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DriveNow.Controllers
{
  
    public class AdminController : ControllerBase
    {
        private readonly DriveNowContext _context;
        private readonly IConfiguration _configuration;

        public AdminController(IConfiguration configuration, DriveNowContext context)
        {
            _configuration = configuration;
            _context = context;
        }
       /* [Authorize("Admin")]*/
     /*   [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            User _user = await _context.User.FindAsync(id);
            if (_user == null)
            {
                return BadRequest("Owner not found");
            }
            _context.User.Remove(_user);
            await _context.SaveChangesAsync();
            return Ok(_user);
        }*/
    }
}
