using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Weapons
{
    public class SnowdriftArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 7;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;             
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("SnowdriftArrowProjectile");  
            item.shootSpeed = 3f;                  
            item.ammo = AmmoID.Arrow;              
        }
       public override void OnConsumeAmmo(Player player)
        {
            if (Main.rand.NextBool(5))
            {
                player.AddBuff(BuffID.Chilled, 300);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlock, 1);
            recipe.AddIngredient(ItemID.SnowBlock, 1);
            recipe.AddIngredient(mod.ItemType("PermafrostShard"), 1);
            recipe.AddTile(TileID.IceMachine);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
