﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebTech.Shared.Models
{
    public partial class PostMeta
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public string Key { get; set; }
        public string Content { get; set; }

        public virtual Post Post { get; set; }
    }
}