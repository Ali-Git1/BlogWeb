using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
               
                    Id= Guid.Parse("5B962013-37DD-4C4B-BBD7-8CDA3FCACB3D"),
                    FileName ="images/testimage",
                    FileType="jpg",
                    CreatedBy="Admin test",
                    CreatedDate=DateTime.Now,
                    IsDeleted=false
                
            },

            new Image
            {
                Id = Guid.Parse("CE51C739-CF67-4F79-8204-25B09C3BAC4B"),
                FileName = "images/vstest",
                FileType = "png",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            });


            
        }
    }
}
