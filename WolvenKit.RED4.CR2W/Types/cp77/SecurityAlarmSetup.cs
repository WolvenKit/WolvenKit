using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmSetup : CVariable
	{
		private CBool _useSound;
		private CName _alarmSound;

		[Ordinal(0)] 
		[RED("useSound")] 
		public CBool UseSound
		{
			get
			{
				if (_useSound == null)
				{
					_useSound = (CBool) CR2WTypeManager.Create("Bool", "useSound", cr2w, this);
				}
				return _useSound;
			}
			set
			{
				if (_useSound == value)
				{
					return;
				}
				_useSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("alarmSound")] 
		public CName AlarmSound
		{
			get
			{
				if (_alarmSound == null)
				{
					_alarmSound = (CName) CR2WTypeManager.Create("CName", "alarmSound", cr2w, this);
				}
				return _alarmSound;
			}
			set
			{
				if (_alarmSound == value)
				{
					return;
				}
				_alarmSound = value;
				PropertySet(this);
			}
		}

		public SecurityAlarmSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
