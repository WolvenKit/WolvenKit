
namespace WolvenKit.RED4.Types
{
	public abstract partial class ItemFilters : IScriptable
	{
		public ItemFilters()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
