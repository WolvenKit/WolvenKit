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
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
