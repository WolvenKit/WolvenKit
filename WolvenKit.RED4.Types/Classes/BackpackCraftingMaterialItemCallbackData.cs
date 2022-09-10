using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackpackCraftingMaterialItemCallbackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("craftingMaterial")] 
		public CHandle<CachedCraftingMaterial> CraftingMaterial
		{
			get => GetPropertyValue<CHandle<CachedCraftingMaterial>>();
			set => SetPropertyValue<CHandle<CachedCraftingMaterial>>(value);
		}

		public BackpackCraftingMaterialItemCallbackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
