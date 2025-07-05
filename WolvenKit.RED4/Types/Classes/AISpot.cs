
namespace WolvenKit.RED4.Types
{
	public abstract partial class AISpot : ISerializable
	{
		public AISpot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
