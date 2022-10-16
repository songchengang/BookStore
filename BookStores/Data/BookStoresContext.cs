using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore1.Models;

namespace BookStores.Data
{
    public class BookStoresContext : DbContext
    {
        public BookStoresContext (DbContextOptions<BookStoresContext> options)
            : base(options)
        {
        }

        public DbSet<BookStore1.Models.Book> Book { get; set; } = default!;
    }
}
