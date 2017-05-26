using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions
{
	public class EndlessWrathPotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Wrath Potion");
            Tooltip.SetDefault("Infinitely provides Wrath");
        }

        public override void SetDefaults()
		{
			item.width = 14;
			item.height = 24;
            item.useStyle = 2;
            item.useTime = 17;
            item.useAnimation = 17;
            item.UseSound = SoundID.Item3;
            item.buffType = BuffID.Wrath;
            item.buffTime = 216000;
			item.value = 25000;
			item.rare = 2;		
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WrathPotion, 30);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}