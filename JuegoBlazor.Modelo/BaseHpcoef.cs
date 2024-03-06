using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class BaseHpcoef
{
    public int IdBaseHpcoef { get; set; }

    public double A { get; set; }

    public double B { get; set; }

    public double C { get; set; }

    public double CpMod { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
