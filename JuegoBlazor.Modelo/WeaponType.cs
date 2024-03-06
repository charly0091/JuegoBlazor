using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class WeaponType
{
    public int IdWeaponType { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool IsTwoHand { get; set; }

    public int BaseCritical { get; set; }

    public int BaseAtkSpeed { get; set; }

    public virtual ICollection<ItemsWeapon> ItemsWeapons { get; set; } = new List<ItemsWeapon>();

    public virtual ICollection<WeaponEnchant> WeaponEnchants { get; set; } = new List<WeaponEnchant>();
}
