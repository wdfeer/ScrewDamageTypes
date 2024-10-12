using System.Collections.Generic;
using ScrewDamageTypes.Content.Player;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Items;

public class CyclingEmblem : ModItem
{
	public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs((int)(DAMAGE_INCREASE * 100f));
	private const float DAMAGE_INCREASE = 0.15f;
	
	public override void SetDefaults()
	{
		Item.width = 28;
		Item.height = 28;
		
		Item.value = Item.buyPrice(gold: 1);
		Item.rare = ItemRarityID.Pink;
		
		Item.accessory = true;
	}

	public override void AddRecipes() =>
		ItemID.Sets.ShimmerTransformToItem[ItemID.AvengerEmblem] = ModContent.ItemType<CyclingEmblem>();

	private DamageClass type = DamageClass.Melee;

	private int cycleTimer;
	
	public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
	{
		cycleTimer++;
        player.GetModPlayer<DamageTypePlayer>().SetDamageType(type);
		
		if (cycleTimer < CYCLE_INTERVAL) return;
        
		CycleDamageType(ref type);

		cycleTimer = 0;
	}
	
	public const int CYCLE_INTERVAL = 60;

	public static void CycleDamageType(ref DamageClass type) => type = NextDamageClass[type] ?? type;

	private static readonly Dictionary<DamageClass, DamageClass> NextDamageClass = new()
	{
		{ DamageClass.Melee, DamageClass.Ranged },
		{ DamageClass.Ranged, DamageClass.Magic },
		{ DamageClass.Magic, DamageClass.Summon },
		{ DamageClass.Summon, DamageClass.Melee }
	};
}