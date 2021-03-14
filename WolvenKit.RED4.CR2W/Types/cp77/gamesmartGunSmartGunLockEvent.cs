using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunSmartGunLockEvent : redEvent
	{
		private CBool _locked;
		private CBool _lockedOnByPlayer;

		[Ordinal(0)] 
		[RED("locked")] 
		public CBool Locked
		{
			get
			{
				if (_locked == null)
				{
					_locked = (CBool) CR2WTypeManager.Create("Bool", "locked", cr2w, this);
				}
				return _locked;
			}
			set
			{
				if (_locked == value)
				{
					return;
				}
				_locked = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lockedOnByPlayer")] 
		public CBool LockedOnByPlayer
		{
			get
			{
				if (_lockedOnByPlayer == null)
				{
					_lockedOnByPlayer = (CBool) CR2WTypeManager.Create("Bool", "lockedOnByPlayer", cr2w, this);
				}
				return _lockedOnByPlayer;
			}
			set
			{
				if (_lockedOnByPlayer == value)
				{
					return;
				}
				_lockedOnByPlayer = value;
				PropertySet(this);
			}
		}

		public gamesmartGunSmartGunLockEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
