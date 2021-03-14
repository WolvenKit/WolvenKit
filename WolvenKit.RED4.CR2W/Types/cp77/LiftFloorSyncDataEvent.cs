using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftFloorSyncDataEvent : redEvent
	{
		private CBool _isHidden;
		private CBool _isInactive;

		[Ordinal(0)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get
			{
				if (_isHidden == null)
				{
					_isHidden = (CBool) CR2WTypeManager.Create("Bool", "isHidden", cr2w, this);
				}
				return _isHidden;
			}
			set
			{
				if (_isHidden == value)
				{
					return;
				}
				_isHidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get
			{
				if (_isInactive == null)
				{
					_isInactive = (CBool) CR2WTypeManager.Create("Bool", "isInactive", cr2w, this);
				}
				return _isInactive;
			}
			set
			{
				if (_isInactive == value)
				{
					return;
				}
				_isInactive = value;
				PropertySet(this);
			}
		}

		public LiftFloorSyncDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
