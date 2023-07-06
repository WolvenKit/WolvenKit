
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldTrafficSourceNode : worldSplineNode
	{
		public worldTrafficSourceNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
