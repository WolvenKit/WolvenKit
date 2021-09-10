using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleBreakFreeEvents : GrappleStandEvents
	{
		[Ordinal(5)] 
		[RED("playerPositionVerified")] 
		public CBool PlayerPositionVerified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("shouldPushPlayerAway")] 
		public CBool ShouldPushPlayerAway
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
