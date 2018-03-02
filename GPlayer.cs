using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace Sprint
{
	public class GPlayer : ModPlayer
	{
		public int endurance = 300, maxEndurance = 300;
		public bool tired = false, init = false;
		public void Initialize()
		{
			endurance = maxEndurance;
			tired = false;
		}
		public override void PreUpdate()
		{
			if(endurance > 0 && !tired && player.velocity.X != 0 && Main.GetKeyState((int)Microsoft.Xna.Framework.Input.Keys.LeftShift) < 0){
				player.moveSpeed += 0.5f;
				player.runAcceleration += 0.05f;
				player.maxRunSpeed += 2.0f;
				player.accRunSpeed += 0.5f;
				endurance--;
			}
			if(endurance == maxEndurance && tired){
				Main.NewText("Ready to go!", 160,160,255);
				tired = false;
			}
			if(endurance <= 0 && !tired){
				Main.NewText("Tired out", 255,160,160);
				tired = true;
			}
			if(player.velocity.X == 0 && endurance < maxEndurance){
				endurance++;
			}
			if(endurance > maxEndurance){
				endurance = maxEndurance;
			}
		}
	}
}