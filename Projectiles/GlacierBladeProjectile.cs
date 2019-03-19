using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Projectiles
{
	
	public class GlacierBladeProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glacier Blade Projectile");
		}
		
		public override void SetDefaults()
		{
			projectile.width = 24;
			projectile.height = 30;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.penetrate = 3;
			projectile.timeLeft = 1600;
			projectile.light = 1.25f;
			projectile.extraUpdates = 1;
			projectile.ignoreWater = true;
		}
		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
		}
	}
}
