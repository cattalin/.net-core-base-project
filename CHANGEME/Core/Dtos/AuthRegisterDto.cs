﻿using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class AuthRegisterDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName{ get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int CompanyId { get; set; }
    }
}
