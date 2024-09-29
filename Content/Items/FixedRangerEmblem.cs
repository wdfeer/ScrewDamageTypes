using ScrewDamageTypes.Content.Items.Abstract;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Items;

public class FixedRangerEmblem : FixedEmblem
{
    protected override DamageClass DamageType => DamageClass.Ranged;
    protected override int BaseEmblemID => ItemID.RangerEmblem;
}