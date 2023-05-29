﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebTech.Shared.Models
{
    public partial class User
    {
        public User()
        {
            Post = new HashSet<Post>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Intro { get; set; }
        public string Profile { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}