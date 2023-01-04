﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.QueryOperation.Users
{
    public class UsersDisplayDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }
    }
}
