using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessChlorophyteBullet : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Chlorophyte Pouch");
            Tooltip.SetDefault("Chases after your enemy... infinitely.");
        }

        public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 4.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.ChlorophyteBullet;
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}