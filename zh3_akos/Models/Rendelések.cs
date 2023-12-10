using System;
using System.Collections.Generic;

namespace zh3_akos.Models;

public partial class Rendelések
{
    public int RendelésId { get; set; }

    public int? SzállítóId { get; set; }

    public int? TermékId { get; set; }

    public int? Mennyiség { get; set; }

    public DateTime? RendelésDátuma { get; set; }

    public DateTime? SzállításDátuma { get; set; }

    public virtual Szállítók? Szállító { get; set; }

    public virtual Termékek? Termék { get; set; }
}
