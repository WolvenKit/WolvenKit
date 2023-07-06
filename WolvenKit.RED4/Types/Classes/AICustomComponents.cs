
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICustomComponents : AIRelatedComponents
	{
		public AICustomComponents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
