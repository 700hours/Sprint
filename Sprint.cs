using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sprint
{
	public class Sprint : Mod
	{
		public void SetModInfo(out string name, ref ModProperties properties)
		{
			name = "Sprint";
			properties.Autoload = true;
			properties.AutoloadGores = true;
			properties.AutoloadSounds = true;
		}
	}
}
