using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace AybrixalMod.Items
{
    public class MilkandCookie : ModItem

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
            item.mountType = mod.MountType("SantasSleigh");

        }



        public override void SetStaticDefaults()

        {
            DisplayName.SetDefault("Milk and Cookies");
            Tooltip.SetDefault("It's not for you");

        }
    }

}
