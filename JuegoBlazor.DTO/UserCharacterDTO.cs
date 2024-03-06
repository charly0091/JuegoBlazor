using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class UserCharacterDTO
    {
        public int IdUserCharacter { get; set; }

        public int IdUser { get; set; }

        public int IdCharacter { get; set; }

        public virtual CharacterDTO IdCharacterNavigation { get; set; } = null!;

        public virtual UserDTO IdUserNavigation { get; set; } = null!;
    }
}
