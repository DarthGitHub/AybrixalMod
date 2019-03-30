using Terraria.ModLoader;
using Terraria.ID;

namespace AybrixalMod.Items
{
    public class SealFlesh : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 300;
            item.rare = 3;
            item.UseSound = SoundID.Item79;
            item.noMelee = true;
            item.mountType = mod.MountType("TamedPolarBear");
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Seal Flesh");
            Tooltip.SetDefault("It's squishy");
        }

        
    }
}
