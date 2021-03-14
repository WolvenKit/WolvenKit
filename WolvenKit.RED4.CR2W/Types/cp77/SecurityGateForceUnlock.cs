using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateForceUnlock : redEvent
	{
		private entEntityID _entranceAllowedFor;
		private CBool _shouldUnlock;

		[Ordinal(0)] 
		[RED("entranceAllowedFor")] 
		public entEntityID EntranceAllowedFor
		{
			get
			{
				if (_entranceAllowedFor == null)
				{
					_entranceAllowedFor = (entEntityID) CR2WTypeManager.Create("entEntityID", "entranceAllowedFor", cr2w, this);
				}
				return _entranceAllowedFor;
			}
			set
			{
				if (_entranceAllowedFor == value)
				{
					return;
				}
				_entranceAllowedFor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shouldUnlock")] 
		public CBool ShouldUnlock
		{
			get
			{
				if (_shouldUnlock == null)
				{
					_shouldUnlock = (CBool) CR2WTypeManager.Create("Bool", "shouldUnlock", cr2w, this);
				}
				return _shouldUnlock;
			}
			set
			{
				if (_shouldUnlock == value)
				{
					return;
				}
				_shouldUnlock = value;
				PropertySet(this);
			}
		}

		public SecurityGateForceUnlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
