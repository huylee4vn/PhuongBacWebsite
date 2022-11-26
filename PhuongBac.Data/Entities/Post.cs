using PhuongBac.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public int RegionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public int SortOrder { get; set; }
        public int ViewCount { get; set; }
        public int IsHot { get; set; }
        public int ShowInHome { get; set; }
        public Status Status { get; set; }
        public List<PostInCategory> PostInCategories { get; set; }
        public List<TagInPost> TagInPosts { get; set; }
        public Type Type { get; set; }
    }
}
