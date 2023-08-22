
namespace WolvenKit.RED4.Types
{
	public abstract partial class SortingDropdownData : IScriptable
	{
		public SortingDropdownData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
