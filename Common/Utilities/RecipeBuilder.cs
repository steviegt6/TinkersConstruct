using Terraria.ModLoader;

namespace TinkersConstruct.Common.Utilities
{
    public static class RecipeBuilder
    {
        public static ModRecipe CreateRecipe(this Mod mod, int itemType, int itemAmount)
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(itemType, itemAmount);

            return recipe;
        }

        public static ModRecipe CreateRecipe(this Mod mod, ModItem modItem, int itemAmount)
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(modItem, itemAmount);

            return recipe;
        }

        public static ModRecipe BuilderAddIngredient(this ModRecipe recipe, int itemType, int itemAmount)
        {
            recipe.AddIngredient(itemType, itemAmount);

            return recipe;
        }

        public static ModRecipe BuilderAddIngredient(this ModRecipe recipe, ModItem modItem, int itemAount)
        {
            recipe.AddIngredient(modItem, itemAount);

            return recipe;
        }

        public static ModRecipe BuilderAddTile(this ModRecipe recipe, ModTile modTile)
        {
            recipe.AddTile(modTile);

            return recipe;
        }

        public static ModRecipe BuilderAddTile(this ModRecipe recipe, int tileType)
        {
            recipe.AddTile(tileType);

            return recipe;
        }

        public static ModRecipe BuilderSetResult(this ModRecipe recipe, int resultType, int resultAmount)
        {
            recipe.SetResult(resultType, resultAmount);

            return recipe;
        }

        public static ModRecipe BuilderSetResult(this ModRecipe recipe, ModItem modItem, int resultAmount)
        {
            recipe.SetResult(modItem, resultAmount);

            return recipe;
        }
    }
}
