using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("BE91E13B-E1FB-49FD-A1C7-F3E13F809EE1"),
                Name = "Asp.net core",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },

            new Category
            {
              
                    Id = Guid.Parse("98598DFA-76F2-4F0C-A448-AA5F2A7CC5FB"),
                    Name = "Visual Studio 2022",
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                

            });








        }
    }
}
