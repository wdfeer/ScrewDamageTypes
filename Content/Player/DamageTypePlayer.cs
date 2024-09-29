#nullable enable
using Terraria;
using Terraria.ModLoader;
using static ScrewDamageTypes.Content.LogicHelper;

namespace ScrewDamageTypes.Content.Player;

public class DamageTypePlayer : ModPlayer
{
    public void SetDamageType(DamageClass damageType) => this.type = damageType;

    private DamageClass? type; 
    
    public override void ResetEffects()
    {
        type = null;
        ResetDamageTypes(Player.inventory);
    }

    public override void UpdateEquips()
    {
        if (type != null) SetDamageTypes(Player.inventory, type);
    }
    
    public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
    {
        if (type != null) modifiers = modifiers with { DamageType = type};
    }
}