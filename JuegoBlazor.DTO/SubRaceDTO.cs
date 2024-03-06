using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class SubRaceDTO
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

        public virtual RaceDTO? IdRaceNavigation { get; set; }
    }
}
