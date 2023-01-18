
namespace WolvenKit.RED4.Types
{
	public partial class mpServerPlayer : mpPlayer
	{
		public mpServerPlayer()
		{
			PeerID = new() { Value = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
