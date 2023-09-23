using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAlarmBreachResponse : ActionBool
	{
		[Ordinal(38)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		public SecurityAlarmBreachResponse()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
