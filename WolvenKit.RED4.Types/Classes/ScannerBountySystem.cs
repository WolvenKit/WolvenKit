using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerBountySystem : ScannerChunk
	{
		private BountyUI _bounty;

		[Ordinal(0)] 
		[RED("bounty")] 
		public BountyUI Bounty
		{
			get => GetProperty(ref _bounty);
			set => SetProperty(ref _bounty, value);
		}
	}
}
