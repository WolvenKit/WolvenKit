
namespace WolvenKit.RED4.Types
{
	public abstract partial class questCondition : questIBaseCondition
	{
		public questCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
