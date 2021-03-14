using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmBreachResponse : ActionBool
	{
		private CEnum<ESecuritySystemState> _currentSecurityState;

		[Ordinal(25)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get
			{
				if (_currentSecurityState == null)
				{
					_currentSecurityState = (CEnum<ESecuritySystemState>) CR2WTypeManager.Create("ESecuritySystemState", "currentSecurityState", cr2w, this);
				}
				return _currentSecurityState;
			}
			set
			{
				if (_currentSecurityState == value)
				{
					return;
				}
				_currentSecurityState = value;
				PropertySet(this);
			}
		}

		public SecurityAlarmBreachResponse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
