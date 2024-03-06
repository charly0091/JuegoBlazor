using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class Class
{
    public int IdClass { get; set; }

    public int? ParentId { get; set; }

    public int? IdSubRace { get; set; }

    public int? Prof { get; set; }

    public string? ClassName { get; set; }

    public int IdBaseHpcoef { get; set; }

    public virtual ICollection<Character> Characters { get; set; } = new List<Character>();

    public virtual BaseHpcoef IdBaseHpcoefNavigation { get; set; } = null!;

    public virtual SubRace? IdSubRaceNavigation { get; set; }

    public virtual ICollection<Class> InverseParent { get; set; } = new List<Class>();

    public virtual Class? Parent { get; set; }
}
