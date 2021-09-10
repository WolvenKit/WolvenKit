using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AbstractLandEvents : LocomotionGroundEvents
	{
		[Ordinal(3)] 
		[RED("blockLandingStimBroadcasting")] 
		public CBool BlockLandingStimBroadcasting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
