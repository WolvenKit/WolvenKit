
namespace WolvenKit.RED4.Types
{
	public abstract partial class ItemFilterCategories : IScriptable
	{
		public ItemFilterCategories()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
