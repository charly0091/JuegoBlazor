using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class UserCharacter
{
    public int IdUserCharacter { get; set; }

    public int IdUser { get; set; }

    public int IdCharacter { get; set; }

    public virtual Character IdCharacterNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
