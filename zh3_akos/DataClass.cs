using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh3_akos
{
    public class DataClass
    {
        public int? TermékId { get; set; }

        public string? Név { get; set; }

        public string? Kategória { get; set; }

        public decimal? Ár { get; set; }

        public bool? Raktáron { get; set; }
    }
}
