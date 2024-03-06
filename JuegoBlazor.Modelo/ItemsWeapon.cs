using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class ItemsWeapon
{
    public int IdItemWeapon { get; set; }

    public int IdItem { get; set; }

    public int IdWeaponType { get; set; }

    public int IdGrade { get; set; }

    public int PAtk { get; set; }

    public int MAtk { get; set; }

    public int SoulShot { get; set; }

    public int SpiritShot { get; set; }

    public int Price { get; set; }

    public bool? Sellable { get; set; }

    public virtual ICollection<Character> Characters { get; set; } = new List<Character>();

    public virtual Grade IdGradeNavigation { get; set; } = null!;

    public virtual Item IdItemNavigation { get; set; } = null!;

    public virtual WeaponType IdWeaponTypeNavigation { get; set; } = null!;
}
