
namespace WolvenKit.RED4.Types
{
	public abstract partial class graphIGraphNodeCondition : ISerializable
	{
		public graphIGraphNodeCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
