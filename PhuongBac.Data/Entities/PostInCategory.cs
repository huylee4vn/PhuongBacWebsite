using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class PostInCategory
    {
        public int PostId { get; set; }

        public Post Post { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
