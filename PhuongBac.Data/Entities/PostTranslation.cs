using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class PostTranslation
    {
        public int Id { get; set; }
        public string LanguageId { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public Post Post { get; set; }
    }
}
