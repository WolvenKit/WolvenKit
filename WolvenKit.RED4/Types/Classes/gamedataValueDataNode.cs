
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamedataValueDataNode : gamedataDataNode
	{
		public gamedataValueDataNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
