
namespace WolvenKit.RED4.Types
{
	public partial class mpLocalPlayer : mpPlayer
	{
		public mpLocalPlayer()
		{
			PeerID = new netPeerID { Value = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
