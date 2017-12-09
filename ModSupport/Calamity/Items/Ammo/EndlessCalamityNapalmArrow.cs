using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Calamity.Items.Ammo
{
	public class EndlessCalamityNapalmArrow : ModItem
	{
        Mod otherMod = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Napalm Quiver");
            Tooltip.SetDefault("Provides infinite Napalm Arrows");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("NapalmArrow"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("NapalmArrow"), 3996);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}