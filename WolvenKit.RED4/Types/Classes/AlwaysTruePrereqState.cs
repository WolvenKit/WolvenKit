
namespace WolvenKit.RED4.Types
{
	public partial class AlwaysTruePrereqState : gamePrereqState
	{
		public AlwaysTruePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
