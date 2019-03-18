using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Weapons
{
	public class IcicleBlade : ModItem 
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icicle Blade");
		}
		public override void SetDefaults()
		{
			item.damage = 9;
			item.melee = true;
			item.width = 20;
			item.height = 20;
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
			recipe.AddIngredient(ItemID.SnowBlock, 15);
            recipe.AddIngredient(mod.ItemType("SnowdriftBar, 3"));
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
