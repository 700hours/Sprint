using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sprint.Items
{
	public class SpaighettiPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.maxStack = 30;
			item.width = 14;
			item.height = 24;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 2;
			item.value = 1000;
			item.rare = 1;
			item.consumable = true;
			item.UseSound = SoundID.Item3;
			item.buffType = mod.BuffType("AteCarbs");
			item.buffTime = 36000;
		//	item.noMelee = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.RottenChunk, 5);
			recipe.AddIngredient(ItemID.GoldOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	/*	public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("You ate your carbs"),36000,false);
			return true; //base.UseItem(player);
		} */
	}
}