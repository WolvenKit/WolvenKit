
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIRPGPrereq : gameIComparisonPrereq
	{
		public gameIRPGPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
