using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorSetup : CVariable
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
			get
			{
				if (_doorType == null)
				{
					_doorType = (CEnum<EDoorType>) CR2WTypeManager.Create("EDoorType", "doorType", cr2w, this);
				}
				return _doorType;
			}
			set
			{
				if (_doorType == value)
				{
					return;
				}
				_doorType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("doorTypeSideOne")] 
		public CEnum<EDoorType> DoorTypeSideOne
		{
			get
			{
				if (_doorTypeSideOne == null)
				{
					_doorTypeSideOne = (CEnum<EDoorType>) CR2WTypeManager.Create("EDoorType", "doorTypeSideOne", cr2w, this);
				}
				return _doorTypeSideOne;
			}
			set
			{
				if (_doorTypeSideOne == value)
				{
					return;
				}
				_doorTypeSideOne = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("doorTypeSideTwo")] 
		public CEnum<EDoorType> DoorTypeSideTwo
		{
			get
			{
				if (_doorTypeSideTwo == null)
				{
					_doorTypeSideTwo = (CEnum<EDoorType>) CR2WTypeManager.Create("EDoorType", "doorTypeSideTwo", cr2w, this);
				}
				return _doorTypeSideTwo;
			}
			set
			{
				if (_doorTypeSideTwo == value)
				{
					return;
				}
				_doorTypeSideTwo = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("skillCheckSide")] 
		public CEnum<EDoorSkillcheckSide> SkillCheckSide
		{
			get
			{
				if (_skillCheckSide == null)
				{
					_skillCheckSide = (CEnum<EDoorSkillcheckSide>) CR2WTypeManager.Create("EDoorSkillcheckSide", "skillCheckSide", cr2w, this);
				}
				return _skillCheckSide;
			}
			set
			{
				if (_skillCheckSide == value)
				{
					return;
				}
				_skillCheckSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("authorizationSide")] 
		public CEnum<EDoorSkillcheckSide> AuthorizationSide
		{
			get
			{
				if (_authorizationSide == null)
				{
					_authorizationSide = (CEnum<EDoorSkillcheckSide>) CR2WTypeManager.Create("EDoorSkillcheckSide", "authorizationSide", cr2w, this);
				}
				return _authorizationSide;
			}
			set
			{
				if (_authorizationSide == value)
				{
					return;
				}
				_authorizationSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("doorTriggerSide")] 
		public CEnum<EDoorTriggerSide> DoorTriggerSide
		{
			get
			{
				if (_doorTriggerSide == null)
				{
					_doorTriggerSide = (CEnum<EDoorTriggerSide>) CR2WTypeManager.Create("EDoorTriggerSide", "doorTriggerSide", cr2w, this);
				}
				return _doorTriggerSide;
			}
			set
			{
				if (_doorTriggerSide == value)
				{
					return;
				}
				_doorTriggerSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isShutter")] 
		public CBool IsShutter
		{
			get
			{
				if (_isShutter == null)
				{
					_isShutter = (CBool) CR2WTypeManager.Create("Bool", "isShutter", cr2w, this);
				}
				return _isShutter;
			}
			set
			{
				if (_isShutter == value)
				{
					return;
				}
				_isShutter = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("initialDoorState")] 
		public CEnum<EDoorStatus> InitialDoorState
		{
			get
			{
				if (_initialDoorState == null)
				{
					_initialDoorState = (CEnum<EDoorStatus>) CR2WTypeManager.Create("EDoorStatus", "initialDoorState", cr2w, this);
				}
				return _initialDoorState;
			}
			set
			{
				if (_initialDoorState == value)
				{
					return;
				}
				_initialDoorState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("canPlayerToggleLockState")] 
		public CBool CanPlayerToggleLockState
		{
			get
			{
				if (_canPlayerToggleLockState == null)
				{
					_canPlayerToggleLockState = (CBool) CR2WTypeManager.Create("Bool", "canPlayerToggleLockState", cr2w, this);
				}
				return _canPlayerToggleLockState;
			}
			set
			{
				if (_canPlayerToggleLockState == value)
				{
					return;
				}
				_canPlayerToggleLockState = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("canPlayerToggleSealState")] 
		public CBool CanPlayerToggleSealState
		{
			get
			{
				if (_canPlayerToggleSealState == null)
				{
					_canPlayerToggleSealState = (CBool) CR2WTypeManager.Create("Bool", "canPlayerToggleSealState", cr2w, this);
				}
				return _canPlayerToggleSealState;
			}
			set
			{
				if (_canPlayerToggleSealState == value)
				{
					return;
				}
				_canPlayerToggleSealState = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("automaticallyClosesItself")] 
		public CBool AutomaticallyClosesItself
		{
			get
			{
				if (_automaticallyClosesItself == null)
				{
					_automaticallyClosesItself = (CBool) CR2WTypeManager.Create("Bool", "automaticallyClosesItself", cr2w, this);
				}
				return _automaticallyClosesItself;
			}
			set
			{
				if (_automaticallyClosesItself == value)
				{
					return;
				}
				_automaticallyClosesItself = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get
			{
				if (_openingSpeed == null)
				{
					_openingSpeed = (CFloat) CR2WTypeManager.Create("Float", "openingSpeed", cr2w, this);
				}
				return _openingSpeed;
			}
			set
			{
				if (_openingSpeed == value)
				{
					return;
				}
				_openingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("doorOpeningTime")] 
		public CFloat DoorOpeningTime
		{
			get
			{
				if (_doorOpeningTime == null)
				{
					_doorOpeningTime = (CFloat) CR2WTypeManager.Create("Float", "doorOpeningTime", cr2w, this);
				}
				return _doorOpeningTime;
			}
			set
			{
				if (_doorOpeningTime == value)
				{
					return;
				}
				_doorOpeningTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("doorOpeningStimRange")] 
		public CFloat DoorOpeningStimRange
		{
			get
			{
				if (_doorOpeningStimRange == null)
				{
					_doorOpeningStimRange = (CFloat) CR2WTypeManager.Create("Float", "doorOpeningStimRange", cr2w, this);
				}
				return _doorOpeningStimRange;
			}
			set
			{
				if (_doorOpeningStimRange == value)
				{
					return;
				}
				_doorOpeningStimRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("canPayToUnlock")] 
		public CBool CanPayToUnlock
		{
			get
			{
				if (_canPayToUnlock == null)
				{
					_canPayToUnlock = (CBool) CR2WTypeManager.Create("Bool", "canPayToUnlock", cr2w, this);
				}
				return _canPayToUnlock;
			}
			set
			{
				if (_canPayToUnlock == value)
				{
					return;
				}
				_canPayToUnlock = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("paymentRecordID")] 
		public TweakDBID PaymentRecordID
		{
			get
			{
				if (_paymentRecordID == null)
				{
					_paymentRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "paymentRecordID", cr2w, this);
				}
				return _paymentRecordID;
			}
			set
			{
				if (_paymentRecordID == value)
				{
					return;
				}
				_paymentRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("exposeQuickHacksIfNotConnectedToAP")] 
		public CBool ExposeQuickHacksIfNotConnectedToAP
		{
			get
			{
				if (_exposeQuickHacksIfNotConnectedToAP == null)
				{
					_exposeQuickHacksIfNotConnectedToAP = (CBool) CR2WTypeManager.Create("Bool", "exposeQuickHacksIfNotConnectedToAP", cr2w, this);
				}
				return _exposeQuickHacksIfNotConnectedToAP;
			}
			set
			{
				if (_exposeQuickHacksIfNotConnectedToAP == value)
				{
					return;
				}
				_exposeQuickHacksIfNotConnectedToAP = value;
				PropertySet(this);
			}
		}

		public DoorSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
