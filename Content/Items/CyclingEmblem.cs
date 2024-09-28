using ScrewDamageTypes.Content.Player;
using Terraria;
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
		// TODO: create custom texture and update width, height
		Item.width = 28;
		Item.height = 28;
		
		Item.value = Item.buyPrice(gold: 1);
		Item.rare = ItemRarityID.Pink;
		
		Item.accessory = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.AvengerEmblem, 2);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
	
	public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
	{
		player.GetDamage(DamageClass.Generic).Flat += DAMAGE_INCREASE;
		player.GetModPlayer<CyclingPlayer>().enabled = true;
	}
}