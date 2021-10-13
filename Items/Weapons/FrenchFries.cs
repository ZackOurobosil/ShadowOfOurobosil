using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShadowOfOurobosil.Items.Weapons
{
	public class FrenchFries : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("French Fries");
			Tooltip.SetDefault("A test summoner weapon");
		}

		public override void SetDefaults() 
		{
			Item.CloneDefaults(ItemID);
			Item.shootSpeed *= 0.75f;
			Item.damage = (int)(item.damage * 1.5);


			Item.damage = 10;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 78;
			Item.height = 60;
            Item.useTime = 20;
			Item.useAnimation = 20;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 4;
            Item.value = 1000;
            Item.rare = ItemRarityID.Yellow;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = 10;
            Item.shootSpeed = 16f;
            Item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WoodenBow, 1);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.Register();

			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.WoodenBow, 1);
			recipe2.AddIngredient(ItemID.ManaCrystal, 2);
			recipe2.Register();
		}
	}
}