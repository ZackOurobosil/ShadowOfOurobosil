using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShadowOfOurobosil.Items.Weapons
{
	public class NecromancerScythe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Necromancer Scythe");
			Tooltip.SetDefault("Harvest the souls of the dead");
		}

		public override void SetDefaults() 
		{
			Item.damage = 15;
			Item.DamageType = DamageClass.Melee;
			Item.width = 100;
			Item.height = 90;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 12;
			Item.value = 1000;
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Frostburn, 600); //Met le pnj en feu pour 10 secs
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBroadsword, 1);
			recipe.AddIngredient(ItemID.Torch, 100);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.Register();
		}
	}
}