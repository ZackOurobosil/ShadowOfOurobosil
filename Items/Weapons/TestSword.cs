using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShadowOfOurobosil.Items.Weapons
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("TestSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Master;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override bool? UseItem(Player player) {
			//player.AddBuff(BuffID.Ironskin, 600); Ajoute un buff au joueur pour 10 sec
			return true;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			//target.AddBuff(BuffID.Frostburn, 600); Met le pnj en feu pour 10 secs
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}