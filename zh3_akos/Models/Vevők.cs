using System;
using System.Collections.Generic;

namespace zh3_akos.Models;

public partial class Vevők
{
    public int VevőId { get; set; }

    public string? Név { get; set; }

    public string? Cím { get; set; }

    public string? Telefonszám { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Vásárlások> Vásárlásoks { get; set; } = new List<Vásárlások>();
}
