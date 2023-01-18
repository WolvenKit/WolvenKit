using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("doorType")] 
		public CEnum<EDoorType> DoorType
		{
			get => GetPropertyValue<CEnum<EDoorType>>();
			set => SetPropertyValue<CEnum<EDoorType>>(value);
		}

		[Ordinal(1)] 
		[RED("doorTypeSideOne")] 
		public CEnum<EDoorType> DoorTypeSideOne
		{
			get => GetPropertyValue<CEnum<EDoorType>>();
			set => SetPropertyValue<CEnum<EDoorType>>(value);
		}

		[Ordinal(2)] 
		[RED("doorTypeSideTwo")] 
		public CEnum<EDoorType> DoorTypeSideTwo
		{
			get => GetPropertyValue<CEnum<EDoorType>>();
			set => SetPropertyValue<CEnum<EDoorType>>(value);
		}

		[Ordinal(3)] 
		[RED("skillCheckSide")] 
		public CEnum<EDoorSkillcheckSide> SkillCheckSide
		{
			get => GetPropertyValue<CEnum<EDoorSkillcheckSide>>();
			set => SetPropertyValue<CEnum<EDoorSkillcheckSide>>(value);
		}

		[Ordinal(4)] 
		[RED("authorizationSide")] 
		public CEnum<EDoorSkillcheckSide> AuthorizationSide
		{
			get => GetPropertyValue<CEnum<EDoorSkillcheckSide>>();
			set => SetPropertyValue<CEnum<EDoorSkillcheckSide>>(value);
		}

		[Ordinal(5)] 
		[RED("doorTriggerSide")] 
		public CEnum<EDoorTriggerSide> DoorTriggerSide
		{
			get => GetPropertyValue<CEnum<EDoorTriggerSide>>();
			set => SetPropertyValue<CEnum<EDoorTriggerSide>>(value);
		}

		[Ordinal(6)] 
		[RED("isShutter")] 
		public CBool IsShutter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("initialDoorState")] 
		public CEnum<EDoorStatus> InitialDoorState
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}

		[Ordinal(8)] 
		[RED("canPlayerToggleLockState")] 
		public CBool CanPlayerToggleLockState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("canPlayerToggleSealState")] 
		public CBool CanPlayerToggleSealState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("canPlayerRemotelyAuthorize")] 
		public CBool CanPlayerRemotelyAuthorize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("automaticallyClosesItself")] 
		public CBool AutomaticallyClosesItself
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("doorOpeningTime")] 
		public CFloat DoorOpeningTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("doorOpeningStimRange")] 
		public CFloat DoorOpeningStimRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("canPayToUnlock")] 
		public CBool CanPayToUnlock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("paymentRecordID")] 
		public TweakDBID PaymentRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(17)] 
		[RED("exposeQuickHacksIfNotConnectedToAP")] 
		public CBool ExposeQuickHacksIfNotConnectedToAP
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DoorSetup()
		{
			DoorType = Enums.EDoorType.INTERACTIVE;
			AutomaticallyClosesItself = true;
			OpeningSpeed = 1.000000F;
			DoorOpeningTime = 1.000000F;
			DoorOpeningStimRange = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
