using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class InfiniteExplodingBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Infinite Exploding Bullet";
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Hold on.";
			item.consumable = false;
			item.knockBack = 6.6f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 286;
			item.shootSpeed = 4.7f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ExplodingBullet, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}