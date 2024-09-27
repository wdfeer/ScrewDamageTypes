using System.Collections.Generic;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Player;

public static class Cycling
{
    public static void CycleDamageType(ref DamageClass type) => type = NextDamageClass[type] ?? type;

    private static readonly Dictionary<DamageClass, DamageClass> NextDamageClass = new()
    {
        { DamageClass.Melee, DamageClass.Ranged },
        { DamageClass.Ranged, DamageClass.Magic },
        { DamageClass.Magic, DamageClass.Summon },
        { DamageClass.Summon, DamageClass.Melee }
    };
}