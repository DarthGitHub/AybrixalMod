using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace AybrixalMod.Mounts
{
    public class StraticeCloud : ModMountData
    {
        public override void SetDefaults()
        {
            mountData.buff = mod.BuffType("StraticeCloudBuff");
            mountData.heightBoost = 10;          
            mountData.fallDamage = 0f;
            mountData.runSpeed = 2f;
            mountData.dashSpeed = 10f;
            mountData.flightTimeMax = 400;
            mountData.fatigueMax = 0;
            mountData.jumpHeight = 5;
            mountData.acceleration = 0.20f;
            mountData.jumpSpeed = 6f;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 1;            
            mountData.constantJump = true;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++)
            {
                array[l] = 1;
            }
            mountData.playerYOffsets = array;
            mountData.xOffset = 10;
            mountData.yOffset = 25;           
            mountData.bodyFrame = 3;          
            mountData.playerHeadOffset = 10;
            mountData.standingFrameCount = 1;
            mountData.standingFrameDelay = 1;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 1;
            mountData.runningFrameDelay = 1;
            mountData.runningFrameStart = 0;
            mountData.flyingFrameCount = 1;
            mountData.flyingFrameDelay = 1;
            mountData.flyingFrameStart = 0;
            mountData.inAirFrameCount = 1;
            mountData.inAirFrameDelay = 1;
            mountData.inAirFrameStart = 0;
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
