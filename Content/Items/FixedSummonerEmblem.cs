using ScrewDamageTypes.Content.Items.Abstract;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Items;

public class FixedSummonerEmblem : FixedEmblem
{
    protected override DamageClass DamageType => DamageClass.Summon;
    protected override int BaseEmblemID => ItemID.SummonerEmblem;
}