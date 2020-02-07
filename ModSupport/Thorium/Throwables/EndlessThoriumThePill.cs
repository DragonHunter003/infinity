using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThoriumMod;

namespace Infinity.ModSupport.Thorium.Throwables    
{
	public class EndlessThoriumThePill : ModItem
	{
        Mod thorium = ModLoader.GetMod("ThoriumMod");
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("ThoriumMod") != null;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Pill");
        }

        public override void SetDefaults()
        {
            if (Infinity.instance.thoriumLoaded)
            {
                item.CloneDefaults(thorium.ItemType("ThePill"));
                item.consumable = false;            
                item.maxStack = 1;               
                
            }
        }

		public override void AddRecipes()
		{
            if (Infinity.instance.thoriumLoaded)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("ThePill"), 999);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, thorium.ProjectileType("ThePillPro2"), 0, 0, player.whoAmI, 0, 0);
            }
            else
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, thorium.ProjectileType("ThePillPro"), damage, knockBack, player.whoAmI, 0, 0);
            }
            return false;
        }
    }
}