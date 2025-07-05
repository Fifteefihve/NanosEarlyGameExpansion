using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace NanosEarlyGameExpansion.Content.Items.Weapons
{
    public class DemonStaff : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 18;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Magic;
            Item.damage = 35;
            Item.knockBack = 4;
            Item.crit = 10;
            Item.mana = 6;
            Item.shoot = ProjectileID.AmethystBolt;
            Item.shootSpeed = 10f;

            Item.value = Item.buyPrice(silver: 30);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item8;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 8);
            recipe.AddIngredient(ItemID.GuideVoodooDoll, 1);
            recipe.AddIngredient(ItemID.Amethyst, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
