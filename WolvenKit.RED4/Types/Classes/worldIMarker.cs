
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldIMarker : ISerializable
	{
		public worldIMarker()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
