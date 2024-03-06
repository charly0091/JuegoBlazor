using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class ItemsArmorDTO
    {
        public int IdItemArmor { get; set; }

        public int IdItem { get; set; }

        public int IdArmorType { get; set; }

        public int IdArmorPart { get; set; }

        public int IdGrade { get; set; }

        public int Def { get; set; }

        public int Mp { get; set; }

        public int Price { get; set; }

        public bool? Sellable { get; set; }

        public virtual ArmorPartDTO IdArmorPartNavigation { get; set; } = null!;

        public virtual ArmorTypeDTO IdArmorTypeNavigation { get; set; } = null!;

        public virtual GradeDTO IdGradeNavigation { get; set; } = null!;

        public virtual ItemDTO IdItemNavigation { get; set; } = null!;
    }
}
