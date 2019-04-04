using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace AybrixalMod.Mounts
{
    public class SantasSleigh : ModMountData
    {
        public override void SetDefaults()
        {
            mountData.buff = mod.BuffType("");
            mountData.heightBoost = 58;
            mountData.fallDamage = 0f;
            mountData.runSpeed = 2f;
            mountData.dashSpeed = 5f;
            mountData.flightTimeMax = 350;
            mountData.fatigueMax = 0;
            mountData.jumpHeight = 5;
            mountData.acceleration = 0.20f;
            mountData.jumpSpeed = 6f;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 5;
            mountData.constantJump = true;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++)
            {
                array[l] = 1;
            }
            mountData.playerYOffsets = array;
            mountData.xOffset = 75;
            mountData.yOffset = 26;
            mountData.bodyFrame = 3;
            mountData.playerHeadOffset = 10;
            mountData.standingFrameCount = 1;
            mountData.standingFrameDelay = 1;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 5;
            mountData.runningFrameDelay = 4;
            mountData.runningFrameStart = 0;
            mountData.flyingFrameCount = 5;
            mountData.flyingFrameDelay = 4;
            mountData.flyingFrameStart = 0;
            mountData.inAirFrameCount = 1;
            mountData.inAirFrameDelay = 4;
            mountData.inAirFrameStart = 4;
            mountData.idleFrameCount = 1;
            mountData.idleFrameDelay = 1;
            mountData.idleFrameStart = 0;
            mountData.idleFrameLoop = true;
            mountData.swimFrameCount = mountData.inAirFrameCount;
            mountData.swimFrameDelay = mountData.inAirFrameDelay;
            mountData.swimFrameStart = mountData.inAirFrameStart;
            if (Main.netMode != 2)
            {
                mountData.textureWidth = mountData.frontTexture.Width;
                mountData.textureHeight = mountData.frontTexture.Height;
            }
        }

        public override void UpdateEffects(Player player)
        {
            if (Math.Abs(player.velocity.X) > 4f)
            {
                Rectangle rect = player.getRect();
                Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, 55);
            }
        }
    }
}
