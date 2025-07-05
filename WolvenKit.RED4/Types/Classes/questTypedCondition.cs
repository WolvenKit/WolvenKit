
namespace WolvenKit.RED4.Types
{
	public abstract partial class questTypedCondition : questIBaseCondition
	{
		public questTypedCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
