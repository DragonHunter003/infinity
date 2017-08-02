using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessRocket : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rocket I Munitions Crate");
            Tooltip.SetDefault("Contains an endless supply of Rocket Is");
        }

        public override void SetDefaults()
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 4f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 0;
			item.shootSpeed = 3f;
			item.ammo = AmmoID.Rocket;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RocketI, 3996);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}