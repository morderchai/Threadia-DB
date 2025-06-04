﻿using Common.DbEntities;
using Common.Enums;

namespace UserService.DbEntities
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserType Type { get; set; }  
        public DateTime CreatedAt { get; set; }
    }
}
