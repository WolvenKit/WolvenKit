using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerBountySystem : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("bounty")] 
		public BountyUI Bounty
		{
			get => GetPropertyValue<BountyUI>();
			set => SetPropertyValue<BountyUI>(value);
		}

		public ScannerBountySystem()
		{
			Bounty = new() { Transgressions = new() };
		}
	}
}
