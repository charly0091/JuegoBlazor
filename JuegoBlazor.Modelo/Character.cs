using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class Character
{
    public int IdCharacter { get; set; }

    public int IdClass { get; set; }

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

    public int? Weapon { get; set; }

    public int? UpperBody { get; set; }

    public int? LowerBody { get; set; }

    public int? Helmet { get; set; }

    public int? Gloves { get; set; }

    public int? Shoes { get; set; }

    public int? Shield { get; set; }

    public int? Necklace { get; set; }

    public int? Earring1 { get; set; }

    public int? Earring2 { get; set; }

    public int? Ring1 { get; set; }

    public int? Ring2 { get; set; }

    public virtual ItemsJewellery? Earring1Navigation { get; set; }

    public virtual ItemsJewellery? Earring2Navigation { get; set; }

    public virtual ItemsArmor? GlovesNavigation { get; set; }

    public virtual ItemsArmor? HelmetNavigation { get; set; }

    public virtual Class IdClassNavigation { get; set; } = null!;

    public virtual ItemsArmor? LowerBodyNavigation { get; set; }

    public virtual ItemsJewellery? NecklaceNavigation { get; set; }

    public virtual ItemsJewellery? Ring1Navigation { get; set; }

    public virtual ItemsJewellery? Ring2Navigation { get; set; }

    public virtual ItemsArmor? ShieldNavigation { get; set; }

    public virtual ItemsArmor? ShoesNavigation { get; set; }

    public virtual ItemsArmor? UpperBodyNavigation { get; set; }

    public virtual ICollection<UserCharacter> UserCharacters { get; set; } = new List<UserCharacter>();

    public virtual ItemsWeapon? WeaponNavigation { get; set; }
}
