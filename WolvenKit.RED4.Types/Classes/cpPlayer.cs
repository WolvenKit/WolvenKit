
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpPlayer : gamePlayer
	{

		public cpPlayer()
		{
			PeerID = new() { Value = 255 };
		}
	}
}
