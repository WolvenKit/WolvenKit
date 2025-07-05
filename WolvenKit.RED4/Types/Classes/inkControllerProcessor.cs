
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkControllerProcessor : ISerializable
	{
		public inkControllerProcessor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
