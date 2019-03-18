using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items
{
    public class SnowdriftBar : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Snowdrift Bar");
            Tooltip.SetDefault("It's slippery");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 50;
            item.value = 100;
            item.rare = 1;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.AddIngredient(ItemID.SnowBlock, 10);
            recipe.AddIngredient(ItemID.IceBlock, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
