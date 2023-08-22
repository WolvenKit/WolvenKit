
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldINodeInstance : ISerializable
	{
		public worldINodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
