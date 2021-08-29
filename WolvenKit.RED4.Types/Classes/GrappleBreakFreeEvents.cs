using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleBreakFreeEvents : GrappleStandEvents
	{
		private CBool _playerPositionVerified;
		private CBool _shouldPushPlayerAway;

		[Ordinal(5)] 
		[RED("playerPositionVerified")] 
		public CBool PlayerPositionVerified
		{
			get => GetProperty(ref _playerPositionVerified);
			set => SetProperty(ref _playerPositionVerified, value);
		}

		[Ordinal(6)] 
		[RED("shouldPushPlayerAway")] 
		public CBool ShouldPushPlayerAway
		{
			get => GetProperty(ref _shouldPushPlayerAway);
			set => SetProperty(ref _shouldPushPlayerAway, value);
		}
	}
}
