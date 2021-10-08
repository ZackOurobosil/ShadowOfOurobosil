using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShadowOfOurobosil.Items.Weapons
{
	public class Mk1Paris : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("MK1-Paris");
			Tooltip.SetDefault("A bow fallen from the stars");
		}

		public override void SetDefaults() 
		{
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

		public override bool? UseItem(Player player) {
			player.AddBuff(BuffID.Swiftness, 600);
			return true;
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