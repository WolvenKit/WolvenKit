
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIBaseCondition : graphIGraphNodeCondition
	{
		public questIBaseCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
