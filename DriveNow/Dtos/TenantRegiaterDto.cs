﻿using System.ComponentModel.DataAnnotations;

namespace DriveNow.Dtos
{
    public class TenantRegiaterDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        [Compare("Password")]
        public string RetipedPassword { get; set; } = string.Empty;

        public string CIN { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
}
