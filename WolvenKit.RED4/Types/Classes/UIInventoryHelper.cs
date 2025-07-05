
namespace WolvenKit.RED4.Types
{
	public abstract partial class UIInventoryHelper : IScriptable
	{
		public UIInventoryHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
