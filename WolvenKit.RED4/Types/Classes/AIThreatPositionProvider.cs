
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIThreatPositionProvider : entIPositionProvider
	{
		public AIThreatPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
