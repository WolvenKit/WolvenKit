
namespace WolvenKit.RED4.Types
{
	public partial class mpRemotePlayer : mpPlayer
	{
		public mpRemotePlayer()
		{
			PeerID = new netPeerID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
