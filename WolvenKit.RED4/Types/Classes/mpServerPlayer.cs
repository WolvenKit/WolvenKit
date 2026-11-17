
namespace WolvenKit.RED4.Types
{
	public partial class mpServerPlayer : mpPlayer
	{
		public mpServerPlayer()
		{
			PeerID = new netPeerID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
