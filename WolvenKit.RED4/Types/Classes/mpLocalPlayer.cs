
namespace WolvenKit.RED4.Types
{
	public partial class mpLocalPlayer : mpPlayer
	{
		public mpLocalPlayer()
		{
			PeerID = new netPeerID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
