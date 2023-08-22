
namespace WolvenKit.RED4.Types
{
	public abstract partial class cpSplinePlacementProvider : ISerializable
	{
		public cpSplinePlacementProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
