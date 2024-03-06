using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class ItemsJewelleryDTO
    {
        public int IdItemJewellery { get; set; }

        public int IdItem { get; set; }

        public int IdJewelleryType { get; set; }

        public int IdGrade { get; set; }

        public int MDef { get; set; }

        public int Mp { get; set; }

        public int Price { get; set; }

        public bool? Sellable { get; set; }


        public virtual GradeDTO IdGradeNavigation { get; set; } = null!;

        public virtual ItemDTO IdItemNavigation { get; set; } = null!;

        public virtual JewelleryTypeDTO IdJewelleryTypeNavigation { get; set; } = null!;
    }
}
