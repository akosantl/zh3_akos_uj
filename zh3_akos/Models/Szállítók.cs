using System;
using System.Collections.Generic;

namespace zh3_akos.Models;

public partial class Szállítók
{
    public int SzállítóId { get; set; }

    public string? Név { get; set; }

    public string? Ország { get; set; }

    public string? TevékenységTerület { get; set; }

    public virtual ICollection<Rendelések> Rendeléseks { get; set; } = new List<Rendelések>();
}
