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
			get => GetProperty(ref _currentSecurityState);
			set => SetProperty(ref _currentSecurityState, value);
		}

		public SecurityAlarmBreachResponse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
