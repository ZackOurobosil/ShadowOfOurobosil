using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShadowOfOurobosil.Items.Weapons
{
	public class ParisPrime : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Paris Prime");
			Tooltip.SetDefault("Remade in all its glory");
		}

		public override void SetDefaults() 
		{
			Item.damage = 50;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 78;
			Item.height = 60;
            Item.useTime = 10;
			Item.useAnimation = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 4;
            Item.value = 10000;
            Item.rare = ItemRarityID.Master;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = 10;
            Item.shootSpeed = 16f;
            Item.useAmmo = AmmoID.Arrow;
		}


		public override bool? UseItem(Player player) {
			player.AddBuff(BuffID.Swiftness, 600);
			return true;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
            recipe.AddIngredient(null, "Mk1Paris", 1);
			//recipe.AddIngredient(null, "PreHardmodeToken", 10);  token créé avec un token de chaque boss du prehardmode
			recipe.AddIngredient(ItemID.FallenStar, 100);
			recipe.AddIngredient(ItemID.SoulofLight, 15);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.Register();

			Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(null, "Mk1Paris", 1);
			//recipe.AddIngredient(null, "PreHardmodeToken", 10);  token créé avec un token de chaque boss du prehardmode
			recipe2.AddIngredient(ItemID.ManaCrystal, 20);
			recipe2.AddIngredient(ItemID.SoulofLight, 15);
			recipe2.AddIngredient(ItemID.SoulofNight, 15);
			recipe2.AddTile(TileID.AdamantiteForge);
			recipe2.Register();
		}
	}
}