
namespace WolvenKit.RED4.Types
{
	public abstract partial class IUIInventoryItemStatsProvider : IScriptable
	{
		public IUIInventoryItemStatsProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
