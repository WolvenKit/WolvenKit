
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkanimProcessor : ISerializable
	{
		public inkanimProcessor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
