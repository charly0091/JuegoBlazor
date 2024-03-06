using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class WeaponEnchantDTO
    {
        public int IdWeaponEnchant { get; set; }

        public int IdGrade { get; set; }

        public int IdWeaponType { get; set; }

        public int EnchantLevel { get; set; }

        public virtual GradeDTO IdGradeNavigation { get; set; } = null!;

        public virtual WeaponTypeDTO IdWeaponTypeNavigation { get; set; } = null!;
    }
}
