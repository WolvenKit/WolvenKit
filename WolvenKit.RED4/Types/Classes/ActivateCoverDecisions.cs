
namespace WolvenKit.RED4.Types
{
	public partial class ActivateCoverDecisions : CoverActionTransition
	{
		public ActivateCoverDecisions()
		{
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
