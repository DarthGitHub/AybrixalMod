using Terraria;
using Terraria.ModLoader;

namespace AybrixalMod.Buffs
{
    public class StraticeCloudBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Stratice Cloud");
            Description.SetDefault("It's Like You Aren't Sitting On Anything");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("StraticeCloud"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}
