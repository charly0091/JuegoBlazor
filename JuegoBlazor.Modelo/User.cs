using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class User
{
    public int IdUser { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public virtual ICollection<UserCharacter> UserCharacters { get; set; } = new List<UserCharacter>();

    public virtual ICollection<UserItem> UserItems { get; set; } = new List<UserItem>();
}
