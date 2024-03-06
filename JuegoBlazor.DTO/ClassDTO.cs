using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class ClassDTO
    {
        public int IdClass { get; set; }

        public int? ParentId { get; set; }

        public int? IdSubRace { get; set; }

        public int? Prof { get; set; }

        public string? ClassName { get; set; }


        public virtual SubRaceDTO? IdSubRaceNavigation { get; set; }

        public virtual BaseHpcoefDTO? IdBaseHpcoefNavigation { get; set; }
        public virtual ClassDTO? Parent { get; set; }
    }
}
