using System;
using System.Collections.Generic;

namespace JuegoBlazor.Modelo;

public partial class WeaponEnchant
{
    public int IdWeaponEnchant { get; set; }

    public int IdGrade { get; set; }

    public int IdWeaponType { get; set; }

    public int EnchantLevel { get; set; }

    public virtual Grade IdGradeNavigation { get; set; } = null!;

    public virtual WeaponType IdWeaponTypeNavigation { get; set; } = null!;
}
