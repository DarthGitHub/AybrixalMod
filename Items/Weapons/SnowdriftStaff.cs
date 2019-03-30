using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Weapons
{
    public class SnowdriftStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");
            Item.staff[item.type] = true; 
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.magic = true;
            item.mana = 10;
            item.width = 40;
            item.height = 40;
            item.useTime = 20; 
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true; 
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SnowdriftStaffProjectile");
            item.shootSpeed = 7f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SnowdriftBar"), 4);
            recipe.AddTile(TileID.IceMachine);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
