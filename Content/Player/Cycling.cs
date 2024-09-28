using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Player;

public static class Cycling
{
    public const int CYCLE_INTERVAL = 60;

    public static void CycleDamageType(ref DamageClass type) => type = NextDamageClass[type] ?? type;

    private static readonly Dictionary<DamageClass, DamageClass> NextDamageClass = new()
    {
        { DamageClass.Melee, DamageClass.Ranged },
        { DamageClass.Ranged, DamageClass.Magic },
        { DamageClass.Magic, DamageClass.Summon },
        { DamageClass.Summon, DamageClass.Melee }
    };

    public static void ResetDamageTypes(IEnumerable<Item> items)
    {
        foreach (var item in items) item.DamageType = new Item(item.type).DamageType;
    }
}