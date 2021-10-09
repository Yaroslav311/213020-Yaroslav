﻿using _213020_Yaroslav.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _213020_Yaroslav.Contexts
{
    public class UserContext : DbContext
    {
            public UserContext(DbContextOptions<UserContext> options) : base(options)
            {

            }

            public DbSet<User> Users { get; set; }
        
    }
}
