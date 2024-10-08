using ScrewDamageTypes.Content.Player;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScrewDamageTypes.Content.Items.Abstract;

public abstract class FixedEmblem : ModItem
{
    protected abstract DamageClass DamageType { get; } 
    protected abstract int BaseEmblemID { get; }
    
    public override void SetDefaults()
    {
        Item.width = 28;
        Item.height = 28;
		
        Item.value = Item.buyPrice(gold: 1);
        Item.rare = ItemRarityID.Pink;
		
        Item.accessory = true;
    }
    
    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<CyclingEmblem>());
        recipe.AddIngredient(BaseEmblemID);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.Register();
    }
    
    public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
    {
        player.GetModPlayer<DamageTypePlayer>().SetDamageType(DamageType);
    }
}