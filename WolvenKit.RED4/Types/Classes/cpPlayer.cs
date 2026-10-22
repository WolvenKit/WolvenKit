
namespace WolvenKit.RED4.Types
{
	public partial class cpPlayer : gamePlayer
	{
		public cpPlayer()
		{
			PeerID = new netPeerID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
