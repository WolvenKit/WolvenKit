
namespace WolvenKit.RED4.Types
{
	public partial class mpRemotePlayer : mpPlayer
	{
		public mpRemotePlayer()
		{
			PeerID = new netPeerID { Value = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
