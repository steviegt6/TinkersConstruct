using Terraria.ModLoader;
using TinkersConstruct.Common.Utilities;

namespace TinkersConstruct.Content.Items
{
    /// <summary>
    /// Base item class used by all items of this mod. <br />
    /// Contains basic stuff that could prove useful for some items without interfering with anything/
    /// </summary>
    public abstract class BaseItem : ModItem
    {
        /// <summary>
        /// Shorthand for <c>item.type</c>.
        /// </summary>
        public int Type => item.type;

        /// <summary>
        /// Creates and returns a recipe with your mod item as the result.
        /// </summary>
        /// <param name="resultAmount"></param>
        /// <returns></returns>
        public ModRecipe CreateRecipe(int resultAmount = 1) => mod.CreateRecipe(this, 1);
    }
}
