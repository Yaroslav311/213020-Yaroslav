using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  _213020_Yaroslav.Models;

namespace _213020_Yaroslav.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}

