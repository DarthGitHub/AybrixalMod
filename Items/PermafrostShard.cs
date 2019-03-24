using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.Items
{
    public class PermafrostShard : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Permafrost Shard");
            Tooltip.SetDefault("Cold and sharp..");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 50;
            item.value = 100;
            item.rare = 1;

        }
    }
}
