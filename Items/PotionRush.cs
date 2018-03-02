using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sprint.Items
{
	public class PotionRush : ModItem
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
			item.buffType = mod.BuffType("Hype");
			item.buffTime = 36000;
		//	item.noMelee = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipeG = new ModRecipe(mod);
			recipeG.AddIngredient(ItemID.BottledWater);
			recipeG.AddIngredient(ItemID.Cactus);
			recipeG.AddIngredient(ItemID.GoldOre);
			recipeG.AddTile(TileID.Bottles);
			recipeG.SetResult(this, 1);
			recipeG.AddRecipe();
			ModRecipe recipeP = new ModRecipe(mod);
			recipeP.AddIngredient(ItemID.BottledWater);
			recipeP.AddIngredient(ItemID.Cactus);
			recipeP.AddIngredient(ItemID.PlatinumOre);
			recipeP.AddTile(TileID.Bottles);
			recipeP.SetResult(this, 1);
			recipeP.AddRecipe();
		}
	/*	public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("Hype"),36000,false);
			return true; //base.UseItem(player);
		} */
	}
}