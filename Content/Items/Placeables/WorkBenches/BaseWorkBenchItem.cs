using TinkersConstruct.Common.Utilities;

namespace TinkersConstruct.Content.Items.Placeables.WorkBenches
{

    /// <summary>
    /// Abstract class for crafting stations variants to reduce boilerplate.
    /// </summary>
    public abstract class BaseWorkBenchItem : BaseItem
    {
        public int workBenchItem;

        public BaseWorkBenchItem(int workBenchItem)
        {
            this.workBenchItem = workBenchItem;
        }

        public override void AddRecipes()
        {
            CreateRecipe().BuilderAddIngredient(workBenchItem, 1).AddRecipe();

            mod.CreateRecipe(workBenchItem, 1).BuilderAddIngredient(this, 1).AddRecipe();
        }
    }
}
