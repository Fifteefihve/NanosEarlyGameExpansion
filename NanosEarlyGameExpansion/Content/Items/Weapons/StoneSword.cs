using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace NanosEarlyGameExpansion.Content.Items.Weapons
{
    public class StoneSword : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.autoReuse = false;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 15;
            Item.knockBack = 6;
            Item.crit = 6;

            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 20);
            recipe.AddIngredient(ItemID.StoneBlock, 30);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
