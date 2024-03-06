using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class ItemDTO
    {
        public int IdItem { get; set; }

        public string ItemName { get; set; } = null!;

        public int IdItemType { get; set; }

        public virtual ItemsTypeDTO IdItemTypeNavigation { get; set; } = null!;

    }
}
