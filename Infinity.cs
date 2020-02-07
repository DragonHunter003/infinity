using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Infinity.Items;


namespace Infinity
{
    class Infinity : Mod
    {
        public Infinity()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
        internal bool thoriumLoaded;
        internal static Infinity instance;
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MusketBall, 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.EndlessMusketPouch);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.WoodenArrow, 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.EndlessQuiver);
            recipe.AddRecipe();
        }

        public override void Load()
        {
            instance = this;
            thoriumLoaded = ModLoader.GetMod("ThoriumMod") != null;     
        }
    }
}