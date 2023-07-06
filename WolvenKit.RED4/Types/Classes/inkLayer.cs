
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkLayer : ISerializable
	{
		public inkLayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
