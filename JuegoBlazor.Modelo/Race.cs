using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class Race
{
    public int IdRace { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<SubRace> SubRaces { get; set; } = new List<SubRace>();
}
