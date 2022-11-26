using PhuongBac.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Entities
{
    public class InsurancePartner
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Alt { get; set; }
        public Status Status { get; set; }
    }
}
