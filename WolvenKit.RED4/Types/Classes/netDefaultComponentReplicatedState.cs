
namespace WolvenKit.RED4.Types
{
	public partial class netDefaultComponentReplicatedState : netIComponentState
	{
		public netDefaultComponentReplicatedState()
		{
			Enabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
