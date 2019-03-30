using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SnowdriftMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snowdrift Mask");
            Tooltip.SetDefault("5% Increaseed magic damage");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 2;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ExampleBreastplate") && legs.type == mod.ItemType("ExampleLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.magicDamage *= 0.05f;  
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SnowdriftBar"), 3);
            recipe.AddTile(TileID.IceMachine);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
