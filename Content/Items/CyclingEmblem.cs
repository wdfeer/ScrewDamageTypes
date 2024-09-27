using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Items;

public class CyclingEmblem : ModItem
{
	public override void SetDefaults()
	{
		// TODO: create custom texture and update width, height
		Item.width = 40;
		Item.height = 40;
		
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

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		// TODO: implement functionality
	}
}