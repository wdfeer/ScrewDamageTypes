using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content;

public static class LogicHelper
{
    public static void SetDamageTypes(IEnumerable<Item> items, DamageClass type)
    {
        foreach (var item in items) item.DamageType = type;
    }
    
    public static void ResetDamageTypes(IEnumerable<Item> items)
    {
        foreach (var item in items) item.DamageType = new Item(item.type).DamageType;
    }
}