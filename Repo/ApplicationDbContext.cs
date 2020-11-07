using System;
using System.Collections.Generic;
using System.Text;
using Logic.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Repo
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
