using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShadowOfOurobosil.Items.Placeable
{
	public class MyCrimsonAltar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Altar");
			Tooltip.SetDefault("A placeable Crimson Altar. Cannot be mined to get hardmode ores");
		}

		public override void SetDefaults()
		{
			Item.width = 48;
			Item.height = 34;
			Item.rare = ItemRarityID.Green;
			Item.createTile = ModContent.TileType<MyEvilAltarTile>();
			Item.placeStyle = 1;
			Item.maxStack = 99;
			Item.value = Item.sellPrice(silver: 15);
			Item.useTime = 10;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.useTurn = true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.CrimtaneBar, 10)
				.AddIngredient(ItemID.TissueSample, 15)
				.AddTile(TileID.DemonAltar)
				.Register();
		}
	}
}


