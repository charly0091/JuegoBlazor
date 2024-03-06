using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class ArmorPart
{
    public int IdArmorPart { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ItemsArmor> ItemsArmors { get; set; } = new List<ItemsArmor>();
}
