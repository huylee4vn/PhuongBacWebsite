using PhuongBac.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IsDefault { get; set; }
    }
}
