
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldCookedNode : worldNode
	{
		public worldCookedNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
