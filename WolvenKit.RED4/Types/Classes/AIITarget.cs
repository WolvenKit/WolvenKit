
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIITarget : RedBaseClass
	{
		public AIITarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
