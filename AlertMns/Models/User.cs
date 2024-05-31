﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class User : IdentityUser
    {
        //[Key]
        //public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //Attribut Datatype pour afficher date courte
        public DateTime CreationDate { get; set; }
        public DateTime? ConnectionDate { get; set; }
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public int PositionId { get; set; }
        public int RoleId { get; set; }
    }
}
