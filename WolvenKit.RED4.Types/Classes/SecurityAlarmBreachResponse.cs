using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAlarmBreachResponse : ActionBool
	{
		private CEnum<ESecuritySystemState> _currentSecurityState;

		[Ordinal(25)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get => GetProperty(ref _currentSecurityState);
			set => SetProperty(ref _currentSecurityState, value);
		}
	}
}
