﻿using BookCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Data
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        { 
        }
    }
}
