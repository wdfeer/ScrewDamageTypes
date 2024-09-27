using Terraria;
using Terraria.ModLoader;
using static ScrewDamageTypes.Content.Player.Cycling;

namespace ScrewDamageTypes.Content.Player;

public class CyclingPlayer : ModPlayer
{
    public bool enabled;

    public override void ResetEffects()
    {
        enabled = false;
    }
    
    public DamageClass type = DamageClass.Melee;
    
    public override void UpdateEquips()
    {
        if (!enabled) return;
        
        CycleDamageType(ref type);
        foreach (var item in Player.inventory)
        {
            item.DamageType = type;
        }
    }
    
    public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
    {
        modifiers = modifiers with { DamageType = type};
    }
}