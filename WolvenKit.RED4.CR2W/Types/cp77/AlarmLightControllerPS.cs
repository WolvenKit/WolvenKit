using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AlarmLightControllerPS : BasicDistractionDeviceControllerPS
	{
		private CEnum<ESecuritySystemState> _securityAlarmState;

		[Ordinal(108)] 
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

		public AlarmLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
