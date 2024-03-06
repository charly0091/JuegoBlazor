using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBlazor.DTO
{
    public class UserDTO
    {
        public int IdUser { get; set; }

        public string UserName { get; set; } = null!;

        public string UserPassword { get; set; } = null!;

        public ICollection<UserCharacterDTO> UserCharacters { get; set; } = new List<UserCharacterDTO>();

        public ICollection<UserItemDTO> UserItems { get; set; } = new List<UserItemDTO>();
    }
}
