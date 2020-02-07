using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Thorium.Throwables 
{
	public class EndlessThoriumSoulBomb : ModItem
	{
        Mod otherMod = ModLoader.GetMod("ThoriumMod");
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("ThoriumMod") != null;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Soul Bomb Pouch");
            Tooltip.SetDefault("Provides endless amounts of Soul Bombs.");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("SoulBomb"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("SoulBomb"), 3996);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}