
namespace WolvenKit.RED4.Types
{
	public abstract partial class InventoryGPRestrictionHelper : IScriptable
	{
		public InventoryGPRestrictionHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
