using System;
using System.Collections.Generic;

namespace zh3_akos.Models;

public partial class Vásárlások
{
    public int VásárlásId { get; set; }

    public int? VevőId { get; set; }

    public int? TermékId { get; set; }

    public int? Mennyiség { get; set; }

    public DateTime? VásárlásDátuma { get; set; }

    public virtual Termékek? Termék { get; set; }

    public virtual Vevők? Vevő { get; set; }

}
