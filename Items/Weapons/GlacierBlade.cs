using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Weapons
{
    public class GlacierBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glacier Blade");
        }
        public override void SetDefaults()
        {
            item.damage = 35;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 25;
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
            recipe.AddIngredient(ItemID.Muramasa);
            recipe.AddIngredient(mod.ItemType("IcicleBlade"));
            recipe.AddIngredient(mod.ItemType("SnowdriftBar, 10"));
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
