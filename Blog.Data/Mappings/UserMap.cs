﻿using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();
           
            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var superadmin=new AppUser
            {
                Id=Guid.Parse("9D648AC5-EA43-4FE8-9F3B-51F3DB2B32E6"),
                UserName="superadmin@gmail.com",
                NormalizedUserName="SUPERADMIN@GMAIL.COM",
                Email="superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                PhoneNumber="+994555555555",
                FirstName="Kerem",
                LastName="Keremli",
                PhoneNumberConfirmed=true,
                EmailConfirmed=true,
                SecurityStamp=Guid.NewGuid().ToString(),
                ImageId= Guid.Parse("5B962013-37DD-4C4B-BBD7-8CDA3FCACB3D")


            };
            superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");

            var admin = new AppUser
            {
                Id = Guid.Parse("85CCBEAF-F0DD-429B-8C38-491D7067D233"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "+994777777777",
                FirstName = "Mehmet",
                LastName = "Kilic",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("CE51C739-CF67-4F79-8204-25B09C3BAC4B")

            };
            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            builder.HasData(superadmin, admin);

        }
        private string CreatePasswordHash(AppUser user,string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
