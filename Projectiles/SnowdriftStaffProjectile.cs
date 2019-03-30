using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Projectiles
{
    public class SnowdriftStaffProjectile : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snowdrift Staff Projectile");
        }
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.melee = true;
            projectile.penetrate = 5;
            projectile.timeLeft = 6000;
            projectile.light = 0.9f;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.TerraBeam;

        }

    }

}
