﻿using System.ComponentModel.DataAnnotations;

namespace HairDressR.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
