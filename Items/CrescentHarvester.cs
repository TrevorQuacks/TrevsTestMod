using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrevsTestMod.Items
{


	public class CrescentHarvester : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("TSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Made In China.");
		}

		public override void SetDefaults()
		{
			item.damage = 82;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 20;
			item.rare = 2;
			item.autoReuse = true;
			item.crit = 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glass, 7);
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.AddIngredient(ItemID.MoonCharm, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}