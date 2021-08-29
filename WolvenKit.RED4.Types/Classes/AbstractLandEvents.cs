using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AbstractLandEvents : LocomotionGroundEvents
	{
		private CBool _blockLandingStimBroadcasting;

		[Ordinal(3)] 
		[RED("blockLandingStimBroadcasting")] 
		public CBool BlockLandingStimBroadcasting
		{
			get => GetProperty(ref _blockLandingStimBroadcasting);
			set => SetProperty(ref _blockLandingStimBroadcasting, value);
		}
	}
}
