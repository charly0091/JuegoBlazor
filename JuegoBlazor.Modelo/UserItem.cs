using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class UserItem
{
    public int IdUserItem { get; set; }

    public int IdUser { get; set; }

    public int IdItem { get; set; }

    public virtual Item IdItemNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
