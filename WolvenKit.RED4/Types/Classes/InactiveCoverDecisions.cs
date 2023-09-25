
namespace WolvenKit.RED4.Types
{
	public partial class InactiveCoverDecisions : CoverActionTransition
	{
		public InactiveCoverDecisions()
		{
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
