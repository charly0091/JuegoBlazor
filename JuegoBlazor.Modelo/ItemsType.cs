using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class ItemsType
{
    public int IdItemsType { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
