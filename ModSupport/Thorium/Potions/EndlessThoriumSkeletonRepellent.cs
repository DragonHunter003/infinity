using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Thorium.Potions
{
	public class EndlessThoriumSkeletonRepellent : ModItem
	{
        Mod otherMod = ModLoader.GetMod("ThoriumMod");
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("ThoriumMod") != null;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Skeleton Repellent");
			Tooltip.SetDefault("'En Garde!'");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("SkeletonRepellent"));
                item.consumable = false;
                item.buffTime = 216000;
                item.maxStack = 1;
            }
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
        }

        public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("SkeletonRepellent"), 30);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}