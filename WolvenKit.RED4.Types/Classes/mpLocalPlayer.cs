
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpLocalPlayer : mpPlayer
	{

		public mpLocalPlayer()
		{
			PeerID = new() { Value = 255 };
		}
	}
}
