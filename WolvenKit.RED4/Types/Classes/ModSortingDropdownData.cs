
namespace WolvenKit.RED4.Types
{
	public abstract partial class ModSortingDropdownData : IScriptable
	{
		public ModSortingDropdownData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
