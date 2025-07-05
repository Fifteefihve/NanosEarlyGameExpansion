using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NanosEarlyGameExpansion.Content.Items.Weapons
{
    internal class LeaflineRifle : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 56;
            Item.height = 18;
            Item.scale = 0.8f;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.autoReuse = false;

            Item.DamageType = DamageClass.Magic;
            Item.damage = 30;
            Item.knockBack = 4;
            Item.crit = 3;
            Item.mana = 10;
            Item.shoot = ProjectileID.Leaf;
            Item.shootSpeed = 30f;

            Item.value = Item.buyPrice(silver: 25);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Grass;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 60);
            recipe.AddTile(TileID.LivingLoom);
            recipe.Register();
        }
    }
}
