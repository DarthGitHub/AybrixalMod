using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AybrixalMod.Items.Weapons
{
    public class SnowdriftBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SnowdriftBow");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 15;
            item.noMelee = true;
            item.ranged = true;
            item.width = 69;
            item.height = 40;
            item.useTime = 50;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1;
            item.value = 10000;
            item.rare = 1;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 2f;
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
