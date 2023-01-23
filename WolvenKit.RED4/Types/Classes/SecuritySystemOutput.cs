using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemOutput : ActionBool
	{
		[Ordinal(25)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		[Ordinal(26)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetPropertyValue<CEnum<EBreachOrigin>>();
			set => SetPropertyValue<CEnum<EBreachOrigin>>(value);
		}

		[Ordinal(27)] 
		[RED("originalInputEvent")] 
		public CHandle<SecuritySystemInput> OriginalInputEvent
		{
			get => GetPropertyValue<CHandle<SecuritySystemInput>>();
			set => SetPropertyValue<CHandle<SecuritySystemInput>>(value);
		}

		[Ordinal(28)] 
		[RED("securityStateChanged")] 
		public CBool SecurityStateChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecuritySystemOutput()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
