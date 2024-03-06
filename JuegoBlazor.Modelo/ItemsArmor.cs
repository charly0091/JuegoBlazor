using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class ItemsArmor
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

    public virtual ICollection<Character> CharacterGlovesNavigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterHelmetNavigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterLowerBodyNavigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterShieldNavigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterShoesNavigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterUpperBodyNavigations { get; set; } = new List<Character>();

    public virtual ArmorPart IdArmorPartNavigation { get; set; } = null!;

    public virtual ArmorType IdArmorTypeNavigation { get; set; } = null!;

    public virtual Grade IdGradeNavigation { get; set; } = null!;

    public virtual Item IdItemNavigation { get; set; } = null!;
}
