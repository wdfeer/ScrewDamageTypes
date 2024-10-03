using ScrewDamageTypes.Content.Items.Abstract;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Items;

public class FixedWarriorEmblem : FixedEmblem
{
    protected override DamageClass DamageType => DamageClass.Melee;
    protected override int BaseEmblemID => ItemID.WarriorEmblem;
}
