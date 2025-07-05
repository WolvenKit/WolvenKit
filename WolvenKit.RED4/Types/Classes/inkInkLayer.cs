
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkInkLayer : ISerializable
	{
		public inkInkLayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
