
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpServerPlayer : mpPlayer
	{

		public mpServerPlayer()
		{
			PeerID = new() { Value = 255 };
		}
	}
}
