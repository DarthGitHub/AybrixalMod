using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Weapons
{
    public class SnowdriftSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snowdrift Sword");
        }
        public override void SetDefaults()
        {
            item.damage = 17;
            item.melee = true;
            item.width = 35;
            item.height = 35;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SnowdriftBar, 4"));
            recipe.AddTile(TileID.IceMachine);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
