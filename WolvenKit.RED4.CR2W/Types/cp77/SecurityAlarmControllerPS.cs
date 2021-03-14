using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmControllerPS : MasterControllerPS
	{
		private SecurityAlarmSetup _securityAlarmSetup;
		private CEnum<ESecuritySystemState> _securityAlarmState;

		[Ordinal(104)] 
		[RED("securityAlarmSetup")] 
		public SecurityAlarmSetup SecurityAlarmSetup
		{
			get
			{
				if (_securityAlarmSetup == null)
				{
					_securityAlarmSetup = (SecurityAlarmSetup) CR2WTypeManager.Create("SecurityAlarmSetup", "securityAlarmSetup", cr2w, this);
				}
				return _securityAlarmSetup;
			}
			set
			{
				if (_securityAlarmSetup == value)
				{
					return;
				}
				_securityAlarmSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get
			{
				if (_securityAlarmState == null)
				{
					_securityAlarmState = (CEnum<ESecuritySystemState>) CR2WTypeManager.Create("ESecuritySystemState", "securityAlarmState", cr2w, this);
				}
				return _securityAlarmState;
			}
			set
			{
				if (_securityAlarmState == value)
				{
					return;
				}
				_securityAlarmState = value;
				PropertySet(this);
			}
		}

		public SecurityAlarmControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
