using PhuongBac.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public int SortOrder { get; set; }
        public int IsHot { get; set; }
        public int ShowInHome { get; set; }
        public Status Status { get; set; }
        public List<VideoInCategory> VideoInCategories { get; set; }
    }
}
