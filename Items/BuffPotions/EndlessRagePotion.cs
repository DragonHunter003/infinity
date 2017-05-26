using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions
{
	public class EndlessRagePotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hulk Potion");
            Tooltip.SetDefault("Infinitely provides Rage");
        }

        public override void SetDefaults()
		{
			item.width = 14;
			item.height = 24;
            item.useStyle = 2;
            item.useTime = 17;
            item.useAnimation = 17;
            item.UseSound = SoundID.Item3;
            item.buffType = BuffID.Rage;
            item.buffTime = 216000;
			item.value = 25000;
			item.rare = 2;	
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RagePotion, 30);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}