
namespace WolvenKit.RED4.Types
{
	public abstract partial class UIInventoryItemModsStaticData : IScriptable
	{
		public UIInventoryItemModsStaticData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
