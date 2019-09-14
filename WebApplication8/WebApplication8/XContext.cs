using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8
{
    public class XContext : DbContext
    {
        public XContext(DbContextOptions<XContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Pen> Pens { get; set; }
        public DbSet<Pencil> Pencils { get; set; }
    }
}
