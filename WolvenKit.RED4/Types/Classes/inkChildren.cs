
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkChildren : ISerializable
	{
		public inkChildren()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
