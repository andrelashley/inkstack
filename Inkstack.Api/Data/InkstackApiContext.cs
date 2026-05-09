using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inkstack.Core.Models;

namespace Inkstack.Api.Data
{
    public class InkstackApiContext : DbContext
    {
        public InkstackApiContext (DbContextOptions<InkstackApiContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; } = default!;
    }
}
