using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JuegoBlazor.DTO
{
    public class CharacterDTO
    {
        public int IdCharacter { get; set; }

        public string CharacterName { get; set; } = null!;

        public int? UserId { get; set; }

        public int CharLevel { get; set; }

        public int Experience { get; set; }

        public int NextLevel { get; set; }

        public int StrStat { get; set; }

        public int DexStat { get; set; }

        public int ConStat { get; set; }

        public int IntStat { get; set; }

        public int WitStat { get; set; }

        public int MenStat { get; set; }

        public virtual ClassDTO IdClassNavigation { get; set; } = null!;

        public virtual ItemsJewelleryDTO? Earring1Navigation { get; set; }

        public virtual ItemsJewelleryDTO? Earring2Navigation { get; set; }

        public virtual ItemsArmorDTO? GlovesNavigation { get; set; }

        public virtual ItemsArmorDTO? HelmetNavigation { get; set; }

        public virtual ItemsArmorDTO? LowerBodyNavigation { get; set; }

        public virtual ItemsJewelleryDTO? NecklaceNavigation { get; set; }

        public virtual ItemsJewelleryDTO? Ring1Navigation { get; set; }

        public virtual ItemsJewelleryDTO? Ring2Navigation { get; set; }

        public virtual ItemsArmorDTO? ShieldNavigation { get; set; }

        public virtual ItemsArmorDTO? ShoesNavigation { get; set; }

        public virtual ItemsArmorDTO? UpperBodyNavigation { get; set; }

        public virtual ItemsWeaponDTO? WeaponNavigation { get; set; }
    }
}
