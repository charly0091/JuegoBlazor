using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class Item
{
    public int IdItem { get; set; }

    public string ItemName { get; set; } = null!;

    public int IdItemType { get; set; }

    public virtual ItemsType IdItemTypeNavigation { get; set; } = null!;

    public virtual ICollection<ItemsArmor> ItemsArmors { get; set; } = new List<ItemsArmor>();

    public virtual ICollection<ItemsJewellery> ItemsJewelleries { get; set; } = new List<ItemsJewellery>();

    public virtual ICollection<ItemsWeapon> ItemsWeapons { get; set; } = new List<ItemsWeapon>();

    public virtual ICollection<UserItem> UserItems { get; set; } = new List<UserItem>();
}
