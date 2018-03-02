using Terraria;
using Terraria.ModLoader;

namespace Sprint.Buffs
{
	public class Hype : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hype");
			Description.SetDefault("Must run all the time");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = false;
			longerExpertDebuff = false;
		}	
		public override void Update(Player player,ref int buffIndex) 
		{
			if(player.velocity.X != 0){
				player.moveSpeed += 0.3f;
			//	player.maximumMaxSpeed += 0.3f;
			}
		}
	}
}