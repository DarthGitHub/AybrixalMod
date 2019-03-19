using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AybrixalMod.NPCs
{
    public class AybrixalGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.IceSlime)
            if(Main.rand.Next(7) < 3)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("PermafrostShard"));
            }
        }
    }
}
