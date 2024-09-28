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
        
        ResetDamageTypes(Player.inventory);
    }

    private DamageClass type = DamageClass.Melee;

    private int cycleTimer;
    public override void UpdateEquips()
    {
        if (!enabled) return;
        
        cycleTimer++;
        foreach (var item in Player.inventory) item.DamageType = type;
        
        if (cycleTimer < CYCLE_INTERVAL) return;
        
        CycleDamageType(ref type);

        cycleTimer = 0;
    }
    
    public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
    {
        modifiers = modifiers with { DamageType = type};
    }
}