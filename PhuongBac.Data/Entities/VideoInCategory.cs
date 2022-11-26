using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class VideoInCategory
    {
        public int VideoId { get; set; }

        public Video Video { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
