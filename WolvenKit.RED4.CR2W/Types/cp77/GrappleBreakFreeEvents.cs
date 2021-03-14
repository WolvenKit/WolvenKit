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
			get
			{
				if (_playerPositionVerified == null)
				{
					_playerPositionVerified = (CBool) CR2WTypeManager.Create("Bool", "playerPositionVerified", cr2w, this);
				}
				return _playerPositionVerified;
			}
			set
			{
				if (_playerPositionVerified == value)
				{
					return;
				}
				_playerPositionVerified = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("shouldPushPlayerAway")] 
		public CBool ShouldPushPlayerAway
		{
			get
			{
				if (_shouldPushPlayerAway == null)
				{
					_shouldPushPlayerAway = (CBool) CR2WTypeManager.Create("Bool", "shouldPushPlayerAway", cr2w, this);
				}
				return _shouldPushPlayerAway;
			}
			set
			{
				if (_shouldPushPlayerAway == value)
				{
					return;
				}
				_shouldPushPlayerAway = value;
				PropertySet(this);
			}
		}

		public GrappleBreakFreeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
