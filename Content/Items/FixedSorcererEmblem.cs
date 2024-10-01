using ScrewDamageTypes.Content.Items.Abstract;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Items;

public class FixedSorcererEmblem : FixedEmblem
{
    protected override DamageClass DamageType => DamageClass.Magic;
    protected override int BaseEmblemID => ItemID.SorcererEmblem;
}