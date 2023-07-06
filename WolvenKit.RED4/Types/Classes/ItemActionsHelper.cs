
namespace WolvenKit.RED4.Types
{
	public abstract partial class ItemActionsHelper : IScriptable
	{
		public ItemActionsHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
