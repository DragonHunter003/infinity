using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessGoldenBullet : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Golden Bullet");
            Tooltip.SetDefault("Let's see if this will kill werewolves too");
        }

        public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 3.6f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.GoldenBullet;
			item.shootSpeed = 4.6f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}