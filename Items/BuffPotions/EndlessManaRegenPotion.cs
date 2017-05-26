using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions
{
	public class EndlessManaRegenPotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super Mana Regeneration Potion");
            Tooltip.SetDefault("Infinitely provides Mana Regeneration");
        }

        public override void SetDefaults()
		{
			item.width = 20;
            item.height = 28;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.maxStack = 1;
            item.consumable = false;
            item.value = 10000;
            item.rare = 1;
            item.buffType = BuffID.ManaRegeneration;
            item.buffTime = 216000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaRegenerationPotion, 30);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}