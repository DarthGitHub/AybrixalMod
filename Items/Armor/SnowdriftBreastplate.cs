using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class SnowdriftBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Snowdrift Breastplate");
            Tooltip.SetDefault("Immunity to Chilled ");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 4;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Chilled] = true;
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

