﻿using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Tremor.Items.Throwables
{
    public class EndlessTremorMonsterTooth : ModItem
    {
        Mod otherMod = ModLoader.GetMod("Tremor");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Monster Tooth");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("MonsterTooth"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

        public override void AddRecipes()
        {
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("MonsterTooth"), 3996);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}