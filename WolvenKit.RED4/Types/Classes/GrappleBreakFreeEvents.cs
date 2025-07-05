using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrappleBreakFreeEvents : GrappleStandEvents
	{
		[Ordinal(8)] 
		[RED("playerPositionVerified")] 
		public CBool PlayerPositionVerified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("shouldPushPlayerAway")] 
		public CBool ShouldPushPlayerAway
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GrappleBreakFreeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
