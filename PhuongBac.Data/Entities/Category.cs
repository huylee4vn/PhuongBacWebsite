using PhuongBac.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public int Target { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
        public List<PostInCategory> PostInCategories { get; set; }
        public List<VideoInCategory> VideoInCategories { get; set; }
    }
}
