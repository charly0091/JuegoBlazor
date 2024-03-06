using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class WeaponTypeDTO
    {
        public int IdWeaponType { get; set; }

        public string Descripcion { get; set; } = null!;

        public bool IsTwoHand { get; set; }

        public int BaseCritical { get; set; }

        public int BaseAtkSpeed { get; set; }

    }
}
