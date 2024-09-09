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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId=Guid.Parse("9D648AC5-EA43-4FE8-9F3B-51F3DB2B32E6"),
                RoleId =Guid.Parse("10D0DD6B-7C2B-4B75-93D2-56C97FB54E32"),

            },
            new AppUserRole
            {
                UserId= Guid.Parse("85CCBEAF-F0DD-429B-8C38-491D7067D233"),
                RoleId= Guid.Parse("79D89DA9-54BB-410B-9F6B-D91872FBE633"),
               
            });
        }
    }
}
