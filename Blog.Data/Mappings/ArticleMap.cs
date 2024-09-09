using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net core yoxlama",
                Content = "conetntcinfjdkjjfdkdjfkfdkjfkdjkfkfkfkffdgfdfhgjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbnmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmffffffffffffffffffffffffffffffffffgjkkkkkkkkkkkkkkkkkkkkkkkkkkuuuuuuuuuuuuuuuuuuuuuuuyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyftfhghgjhjhjubh",
                ViewCount = 15,
                CategoryId = Guid.Parse("BE91E13B-E1FB-49FD-A1C7-F3E13F809EE1"),
                ImageID = Guid.Parse("5B962013-37DD-4C4B-BBD7-8CDA3FCACB3D"),
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("9D648AC5-EA43-4FE8-9F3B-51F3DB2B32E6")

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio yoxlama",
                Content = "conetntcinfjdkjjfdkdjfkfdkjfkdjkfkfkfkffdgfdfhgjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbnmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmffffffffffffffffffffffffffffffffffgjkkkkkkkkkkkkkkkkkkkkkkkkkkuuuuuuuuuuuuuuuuuuuuuuuyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyftfhghgjhjhjubh",
                ViewCount = 15,
                CategoryId = Guid.Parse("98598DFA-76F2-4F0C-A448-AA5F2A7CC5FB"),
                ImageID = Guid.Parse("CE51C739-CF67-4F79-8204-25B09C3BAC4B"),
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId= Guid.Parse("85CCBEAF-F0DD-429B-8C38-491D7067D233")
            });


            
            
            
            
        }
    }
}
