using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemOutput : ActionBool
	{
		[Ordinal(38)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		[Ordinal(39)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetPropertyValue<CEnum<EBreachOrigin>>();
			set => SetPropertyValue<CEnum<EBreachOrigin>>(value);
		}

		[Ordinal(40)] 
		[RED("originalInputEvent")] 
		public CHandle<SecuritySystemInput> OriginalInputEvent
		{
			get => GetPropertyValue<CHandle<SecuritySystemInput>>();
			set => SetPropertyValue<CHandle<SecuritySystemInput>>(value);
		}

		[Ordinal(41)] 
		[RED("securityStateChanged")] 
		public CBool SecurityStateChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecuritySystemOutput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
