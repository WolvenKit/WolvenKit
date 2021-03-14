using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrowdSettingsEvent : redEvent
	{
		private CName _movementType;
		private CBool _resetFear;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CName MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CName) CR2WTypeManager.Create("CName", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("resetFear")] 
		public CBool ResetFear
		{
			get
			{
				if (_resetFear == null)
				{
					_resetFear = (CBool) CR2WTypeManager.Create("Bool", "resetFear", cr2w, this);
				}
				return _resetFear;
			}
			set
			{
				if (_resetFear == value)
				{
					return;
				}
				_resetFear = value;
				PropertySet(this);
			}
		}

		public CrowdSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
