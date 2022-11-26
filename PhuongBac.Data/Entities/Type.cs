using PhuongBac.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public List<Post> Posts { get; set; }
    }
}
