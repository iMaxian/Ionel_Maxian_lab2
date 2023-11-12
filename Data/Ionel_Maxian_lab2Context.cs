using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ionel_Maxian_lab2.Models;

namespace Ionel_Maxian_lab2.Data
{
    public class Ionel_Maxian_lab2Context : DbContext
    {
        public Ionel_Maxian_lab2Context (DbContextOptions<Ionel_Maxian_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ionel_Maxian_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ionel_Maxian_lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Ionel_Maxian_lab2.Models.Author>? Author { get; set; }

        public DbSet<Ionel_Maxian_lab2.Models.Category>? Category { get; set; }

        public DbSet<Ionel_Maxian_lab2.Models.Member>? Member { get; set; }

        public DbSet<Ionel_Maxian_lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
