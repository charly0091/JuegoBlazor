using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class UserItemDTO
    {
        public int IdUserItem { get; set; }

        public int IdUser { get; set; }

        public int IdItem { get; set; }

        public virtual ItemDTO IdItemNavigation { get; set; } = null!;

        public virtual UserDTO IdUserNavigation { get; set; } = null!;
    }
}
