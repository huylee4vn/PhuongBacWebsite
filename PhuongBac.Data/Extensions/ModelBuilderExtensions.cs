using Microsoft.EntityFrameworkCore;
using PhuongBac.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig { Key = "HomeTitle", Value = "This is Home title" },
                new AppConfig { Key = "HomeDescription", Value = "This is Home description" },
                new AppConfig { Key = "HomeKeyword", Value = "This is Home keyword" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Giới thiệu", SortOrder = 1, Status = Enums.Status.Active },
                new Category { Id = 2, Name = "Giới thiệu chung", SortOrder = 1, Status = Enums.Status.Active, ParentId = 1 },
                new Category { Id = 3, Name = "Cơ sở vật chất", SortOrder = 1, Status = Enums.Status.Active, ParentId = 1 },
                new Category { Id = 4, Name = "Thư viện", SortOrder = 1, Status = Enums.Status.Active, ParentId = 1 },
                new Category { Id = 5, Name = "Chuyên khoa", SortOrder = 1, Status = Enums.Status.Active },
                new Category { Id = 6, Name = "Dịch vụ", SortOrder = 1, Status = Enums.Status.Active },
                new Category { Id = 7, Name = "Tin tức", SortOrder = 1, Status = Enums.Status.Active },
                new Category { Id = 8, Name = "Liên hệ", SortOrder = 1, Status = Enums.Status.Active }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post { CategoryId = 1, Id = 1, Title = "Giới thiệu chung", Description = "Giới thiệu bệnh viện", Content = "Giới thiệu bệnh viện", ShowInHome = 1, SortOrder = 1, ViewCount = 0, Status = Enums.Status.Active },
                new Post { CategoryId = 1, Id = 2, Title = "Cơ sở vật chất", Description = "Cơ sở vật chất", Content = "Cơ sở vật chất", ShowInHome = 0, SortOrder = 1, ViewCount = 0, Status = Enums.Status.Active }
                );

            modelBuilder.Entity<PostTranslation>().HasData(
                new PostTranslation { Id = 1, LanguageId = "vi-VN", PostId = 1, Name = "Giới thiệu bệnh viện", Description = "Giới thiệu bệnh viện", Detail = "Giới thiệu bệnh viện", SeoTitle = "gioi-thieu-benh-vien", SeoAlias = "gioi-thieu-benh-vien" },
                new PostTranslation { Id = 2, LanguageId = "vi-VN", PostId = 1, Name = "About", Description = "About", Detail = "Giới thiệu bệnh viện", SeoTitle = "about", SeoAlias = "about" }
                );
        }
    }
}
