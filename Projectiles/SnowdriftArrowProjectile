using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Projectiles
{
    public class SnowdriftArrowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SnowdriftArrow");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }
        public override void SetDefaults()
        {
            projectile.width = 8;              
            projectile.height = 8;              
            projectile.aiStyle = 1;             
            projectile.friendly = true;         
            projectile.hostile = false;        
            projectile.ranged = true;          
            projectile.penetrate = 5;           
            projectile.timeLeft = 600;         
            projectile.alpha = 0;            
            projectile.light = 0.5f;            
            projectile.ignoreWater = true;          
            projectile.tileCollide = true;          
            projectile.extraUpdates = 1;
            aiType = ProjectileID.WoodenArrowFriendly;
        }   
    }
}
