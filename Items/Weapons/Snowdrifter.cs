using AybrixalMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Weapons
{
    public class Snowdrifter: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snowdrifter");
            Tooltip.SetDefault("");

            
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.width = 24;
            item.height = 24;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.value = 10000;
            item.rare = 2;
            item.damage = 15;
            item.rare = 0;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(silver: 1);
            item.shoot = mod.ProjectileType<SnowdrifterProjectile>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SnowdriftBar"), 4);
            recipe.AddIngredient(ItemID.Chain, 4);
            recipe.AddTile(TileID.IceMachine);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
