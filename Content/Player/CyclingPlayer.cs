using Terraria;
using Terraria.ModLoader;
using static ScrewDamageTypes.Content.Player.Cycling;

namespace ScrewDamageTypes.Content.Player;

public class CyclingPlayer : ModPlayer
{
    public bool Enabled;

    public override void ResetEffects()
    {
        Enabled = false;
    }

    private DamageClass type = DamageClass.Melee;
        
    private const int INTERVAL = 60;
    private int timer;
    public override void UpdateEquips()
    {
        if (!Enabled) return;

        timer++;

        if (timer < INTERVAL) return;
        
        CycleDamageType(ref type);
        foreach (var item in Player.inventory)
        {
            item.DamageType = type;
        }

        timer = 0;
    }
    
    public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
    {
        modifiers = modifiers with { DamageType = type};
    }
}