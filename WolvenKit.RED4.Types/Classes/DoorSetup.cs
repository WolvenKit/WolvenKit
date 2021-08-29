using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorSetup : RedBaseClass
	{
		private CEnum<EDoorType> _doorType;
		private CEnum<EDoorType> _doorTypeSideOne;
		private CEnum<EDoorType> _doorTypeSideTwo;
		private CEnum<EDoorSkillcheckSide> _skillCheckSide;
		private CEnum<EDoorSkillcheckSide> _authorizationSide;
		private CEnum<EDoorTriggerSide> _doorTriggerSide;
		private CBool _isShutter;
		private CEnum<EDoorStatus> _initialDoorState;
		private CBool _canPlayerToggleLockState;
		private CBool _canPlayerToggleSealState;
		private CBool _automaticallyClosesItself;
		private CFloat _openingSpeed;
		private CFloat _doorOpeningTime;
		private CFloat _doorOpeningStimRange;
		private CBool _canPayToUnlock;
		private TweakDBID _paymentRecordID;
		private CBool _exposeQuickHacksIfNotConnectedToAP;

		[Ordinal(0)] 
		[RED("doorType")] 
		public CEnum<EDoorType> DoorType
		{
			get => GetProperty(ref _doorType);
			set => SetProperty(ref _doorType, value);
		}

		[Ordinal(1)] 
		[RED("doorTypeSideOne")] 
		public CEnum<EDoorType> DoorTypeSideOne
		{
			get => GetProperty(ref _doorTypeSideOne);
			set => SetProperty(ref _doorTypeSideOne, value);
		}

		[Ordinal(2)] 
		[RED("doorTypeSideTwo")] 
		public CEnum<EDoorType> DoorTypeSideTwo
		{
			get => GetProperty(ref _doorTypeSideTwo);
			set => SetProperty(ref _doorTypeSideTwo, value);
		}

		[Ordinal(3)] 
		[RED("skillCheckSide")] 
		public CEnum<EDoorSkillcheckSide> SkillCheckSide
		{
			get => GetProperty(ref _skillCheckSide);
			set => SetProperty(ref _skillCheckSide, value);
		}

		[Ordinal(4)] 
		[RED("authorizationSide")] 
		public CEnum<EDoorSkillcheckSide> AuthorizationSide
		{
			get => GetProperty(ref _authorizationSide);
			set => SetProperty(ref _authorizationSide, value);
		}

		[Ordinal(5)] 
		[RED("doorTriggerSide")] 
		public CEnum<EDoorTriggerSide> DoorTriggerSide
		{
			get => GetProperty(ref _doorTriggerSide);
			set => SetProperty(ref _doorTriggerSide, value);
		}

		[Ordinal(6)] 
		[RED("isShutter")] 
		public CBool IsShutter
		{
			get => GetProperty(ref _isShutter);
			set => SetProperty(ref _isShutter, value);
		}

		[Ordinal(7)] 
		[RED("initialDoorState")] 
		public CEnum<EDoorStatus> InitialDoorState
		{
			get => GetProperty(ref _initialDoorState);
			set => SetProperty(ref _initialDoorState, value);
		}

		[Ordinal(8)] 
		[RED("canPlayerToggleLockState")] 
		public CBool CanPlayerToggleLockState
		{
			get => GetProperty(ref _canPlayerToggleLockState);
			set => SetProperty(ref _canPlayerToggleLockState, value);
		}

		[Ordinal(9)] 
		[RED("canPlayerToggleSealState")] 
		public CBool CanPlayerToggleSealState
		{
			get => GetProperty(ref _canPlayerToggleSealState);
			set => SetProperty(ref _canPlayerToggleSealState, value);
		}

		[Ordinal(10)] 
		[RED("automaticallyClosesItself")] 
		public CBool AutomaticallyClosesItself
		{
			get => GetProperty(ref _automaticallyClosesItself);
			set => SetProperty(ref _automaticallyClosesItself, value);
		}

		[Ordinal(11)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetProperty(ref _openingSpeed);
			set => SetProperty(ref _openingSpeed, value);
		}

		[Ordinal(12)] 
		[RED("doorOpeningTime")] 
		public CFloat DoorOpeningTime
		{
			get => GetProperty(ref _doorOpeningTime);
			set => SetProperty(ref _doorOpeningTime, value);
		}

		[Ordinal(13)] 
		[RED("doorOpeningStimRange")] 
		public CFloat DoorOpeningStimRange
		{
			get => GetProperty(ref _doorOpeningStimRange);
			set => SetProperty(ref _doorOpeningStimRange, value);
		}

		[Ordinal(14)] 
		[RED("canPayToUnlock")] 
		public CBool CanPayToUnlock
		{
			get => GetProperty(ref _canPayToUnlock);
			set => SetProperty(ref _canPayToUnlock, value);
		}

		[Ordinal(15)] 
		[RED("paymentRecordID")] 
		public TweakDBID PaymentRecordID
		{
			get => GetProperty(ref _paymentRecordID);
			set => SetProperty(ref _paymentRecordID, value);
		}

		[Ordinal(16)] 
		[RED("exposeQuickHacksIfNotConnectedToAP")] 
		public CBool ExposeQuickHacksIfNotConnectedToAP
		{
			get => GetProperty(ref _exposeQuickHacksIfNotConnectedToAP);
			set => SetProperty(ref _exposeQuickHacksIfNotConnectedToAP, value);
		}
	}
}
