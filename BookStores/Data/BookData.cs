using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStores.Data;
using System;
using System.Linq;
using BookStore1.Models;

namespace BookStores.Models
{
    public static class BookData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoresContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookStoresContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        BookName = "CQRS for Dummies",
                        BookId = "9b0896fa-3880-4c2e-925c87f22878"
                    },
                     new Book
                     {
                         BookName = "Visual Studio Tips",
                         BookId = "0050818d-36ad-4a8d-9c3a-a715bf15de76"
                     },
                     new Book
                     {
                         BookName = "NHibernate Cookbook",
                         BookId = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1"
                     }

                );
                context.SaveChanges();
            }
        }
    }
}