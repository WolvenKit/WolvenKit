using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrappleBreakFreeEvents : GrappleStandEvents
	{
		private CBool _playerPositionVerified;
		private CBool _shouldPushPlayerAway;

		[Ordinal(2)] 
		[RED("playerPositionVerified")] 
		public CBool PlayerPositionVerified
		{
			get => GetProperty(ref _playerPositionVerified);
			set => SetProperty(ref _playerPositionVerified, value);
		}

		[Ordinal(3)] 
		[RED("shouldPushPlayerAway")] 
		public CBool ShouldPushPlayerAway
		{
			get => GetProperty(ref _shouldPushPlayerAway);
			set => SetProperty(ref _shouldPushPlayerAway, value);
		}

		public GrappleBreakFreeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
