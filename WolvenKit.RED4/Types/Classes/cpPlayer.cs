
namespace WolvenKit.RED4.Types
{
	public partial class cpPlayer : gamePlayer
	{
		public cpPlayer()
		{
			PeerID = new netPeerID { Value = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
