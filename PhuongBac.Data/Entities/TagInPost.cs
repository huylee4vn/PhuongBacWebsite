using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class TagInPost
    {
        public int TagId { get; set; }

        public Tag Tag { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
