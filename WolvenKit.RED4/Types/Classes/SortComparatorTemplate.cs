
namespace WolvenKit.RED4.Types
{
	public abstract partial class SortComparatorTemplate : IScriptable
	{
		public SortComparatorTemplate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
