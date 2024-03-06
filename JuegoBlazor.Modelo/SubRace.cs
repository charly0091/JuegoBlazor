using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class SubRace
{
    public int IdSubRace { get; set; }

    public int? IdRace { get; set; }

    public string? Descripcion { get; set; }

    public bool? Fighter { get; set; }

    public bool? Mystic { get; set; }

    public int? BaseSpeed { get; set; }

    public int? IntStat { get; set; }

    public int? StrStat { get; set; }

    public int? ConStat { get; set; }

    public int? MenStat { get; set; }

    public int? DexStat { get; set; }

    public int? WitStat { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual Race? IdRaceNavigation { get; set; }
}
