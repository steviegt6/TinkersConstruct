using Terraria;
using TinkersConstruct.Common.Utilities;

namespace TinkersConstruct.Content.Items.Placeables.WorkBenches
{

    /// <summary>
    /// Abstract class for crafting stations variants to reduce boilerplate.
    /// </summary>
    public abstract class BaseWorkBenchItem : BaseItem
    {
        public override string Texture => $"Terraria/Item_{workBenchItem}";

        public int workBenchItem;

        public BaseWorkBenchItem(int workBenchItem)
        {
            this.workBenchItem = workBenchItem;
        }

        public override void SetStaticDefaults()
        {
            Item vanillaWorkBench = new Item();
            vanillaWorkBench.SetDefaults(workBenchItem);

            string tooltip = "";

            for (int i = 0; i < vanillaWorkBench.ToolTip.Lines; i++)
                tooltip += vanillaWorkBench.ToolTip.GetLine(i);

            DisplayName.SetDefault(vanillaWorkBench.Name);
            Tooltip.SetDefault(tooltip);
        }

        public override void SetDefaults() => item.CloneDefaults(workBenchItem);

        public override void AddRecipes()
        {
            CreateRecipe().BuilderAddIngredient(workBenchItem, 1).AddRecipe();

            mod.CreateRecipe(workBenchItem, 1).BuilderAddIngredient(this, 1).AddRecipe();
        }
    }
}
