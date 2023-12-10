using System;
using System.Collections.Generic;

namespace zh3_akos.Models;

public partial class Termékek
{
    public int TermékId { get; set; }

    public string? Név { get; set; }

    public string? Kategória { get; set; }

    public decimal? Ár { get; set; }

    public bool? Raktáron { get; set; }

    public virtual ICollection<Rendelések> Rendeléseks { get; set; } = new List<Rendelések>();

    public virtual ICollection<Vásárlások> Vásárlásoks { get; set; } = new List<Vásárlások>();
}
