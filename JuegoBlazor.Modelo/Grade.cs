using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class Grade
{
    public int IdGrade { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ItemsArmor> ItemsArmors { get; set; } = new List<ItemsArmor>();

    public virtual ICollection<ItemsJewellery> ItemsJewelleries { get; set; } = new List<ItemsJewellery>();

    public virtual ICollection<ItemsWeapon> ItemsWeapons { get; set; } = new List<ItemsWeapon>();

    public virtual ICollection<WeaponEnchant> WeaponEnchants { get; set; } = new List<WeaponEnchant>();
}
