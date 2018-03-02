using Terraria;
using Terraria.ModLoader;

namespace Sprint.Buffs
{
	public class AteCarbs : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("You ate your carbs");
			Description.SetDefault("Regain energy faster!");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = false;
			longerExpertDebuff = false;
		}	
		public override void Update(Player player,ref int buffIndex) 
		{
			if(player.velocity.X == 0 && player.GetModPlayer<GPlayer>(mod).endurance < player.GetModPlayer<GPlayer>(mod).maxEndurance){
				player.GetModPlayer<GPlayer>(mod).endurance += 2;
			}
		}
	}
}