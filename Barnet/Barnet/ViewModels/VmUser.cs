﻿using Microsoft.AspNetCore.Identity;
using Barent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barent.ViewModels
{
    public class VmUser
    {
        public List<CustomUser> CustomUsers { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public List<IdentityUserRole<string>> UserRoles { get; set; }
    }
}
