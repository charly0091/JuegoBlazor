using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class ItemsJewellery
{
    public int IdItemJewellery { get; set; }

    public int IdItem { get; set; }

    public int IdJewelleryType { get; set; }

    public int IdGrade { get; set; }

    public int MDef { get; set; }

    public int Mp { get; set; }

    public int Price { get; set; }

    public bool? Sellable { get; set; }

    public virtual ICollection<Character> CharacterEarring1Navigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterEarring2Navigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterNecklaceNavigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterRing1Navigations { get; set; } = new List<Character>();

    public virtual ICollection<Character> CharacterRing2Navigations { get; set; } = new List<Character>();

    public virtual Grade IdGradeNavigation { get; set; } = null!;

    public virtual Item IdItemNavigation { get; set; } = null!;

    public virtual JewelleryType IdJewelleryTypeNavigation { get; set; } = null!;
}
