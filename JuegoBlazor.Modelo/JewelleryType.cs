using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class JewelleryType
{
    public int IdJewelleryType { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ItemsJewellery> ItemsJewelleries { get; set; } = new List<ItemsJewellery>();
}
