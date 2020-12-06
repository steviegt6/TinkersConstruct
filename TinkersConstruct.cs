using Terraria.ModLoader;

namespace TinkersConstruct
{
	public class TinkersConstruct : Mod
	{
		public static TinkersConstruct Instance { get; private set; }

		public TinkersConstruct()
        {
			Instance = this;

			Properties = new ModProperties
			{
				Autoload = true,
				AutoloadBackgrounds = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
        }
	}
}