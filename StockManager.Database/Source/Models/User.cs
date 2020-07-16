﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Source.Models
{
    public class User : BaseEntity
    {
        public DateTime? LastLogin { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public Role Role { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public ICollection<StockMovement> StockMovements { get; set; }

        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
    }
}
