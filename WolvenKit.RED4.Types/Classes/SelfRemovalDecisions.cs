
namespace WolvenKit.RED4.Types
{
	public partial class SelfRemovalDecisions : gamestateMachineFunctor
	{
		public SelfRemovalDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
