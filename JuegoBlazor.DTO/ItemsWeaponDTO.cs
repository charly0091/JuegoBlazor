using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class ItemsWeaponDTO
    {
        public int IdItemWeapon { get; set; }

        public int IdItem { get; set; }

        public int IdWeaponType { get; set; }

        public int IdGrade { get; set; }

        public int PAtk { get; set; }

        public int MAtk { get; set; }

        public int SoulShot { get; set; }

        public int SpiritShot { get; set; }

        public int Price { get; set; }

        public bool? Sellable { get; set; }

        public virtual GradeDTO IdGradeNavigation { get; set; } = null!;

        public virtual ItemDTO IdItemNavigation { get; set; } = null!;

        public virtual WeaponTypeDTO IdWeaponTypeNavigation { get; set; } = null!;
    }
}
