
namespace WolvenKit.RED4.Types
{
	public abstract partial class ItemCategoryFliter : IScriptable
	{
		public ItemCategoryFliter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
