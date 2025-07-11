﻿using System.ComponentModel.DataAnnotations;

namespace UserCrudApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string Email { get; set; }
    }
}