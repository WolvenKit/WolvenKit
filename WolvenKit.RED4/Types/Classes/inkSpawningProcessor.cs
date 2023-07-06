
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkSpawningProcessor : ISerializable
	{
		public inkSpawningProcessor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
