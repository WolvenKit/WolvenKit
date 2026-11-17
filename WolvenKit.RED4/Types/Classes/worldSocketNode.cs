
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldSocketNode : worldNode
	{
		public worldSocketNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
