using Terraria.ID;
using Terraria.ModLoader;

namespace TrevsTestMod.Items
{
	public class IronGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("TSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Look at you moving up in life!");
		}

		public override void SetDefaults()
		{
			item.damage = 117;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}