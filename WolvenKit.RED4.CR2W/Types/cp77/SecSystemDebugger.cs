using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecSystemDebugger : gameScriptableSystem
	{
		private CEnum<EReprimandInstructions> _lastInstruction;
		private CBool _instructionSet;
		private CFloat _lastInstructionTime;
		private CEnum<ESecurityNotificationType> _lastInput;
		private CBool _inputSet;
		private CFloat _lastInputTime;
		private CFloat _lastUpdateTime;
		private gameDelayID _realTimeCallbackID;
		private CBool _realTimeCallback;
		private CFloat _realTime;
		private CArray<CName> _callstack;
		private CArray<CUInt32> _ids;
		private CUInt32 _background;
		private CUInt32 _sysName;
		private CUInt32 _sysState;
		private CUInt32 _mostDangerousArea;
		private CUInt32 _blacklistReason;
		private CUInt32 _blacklistCount;
		private CUInt32 _reprimand;
		private CUInt32 _repInstruction;
		private CUInt32 _reprimandID;
		private CUInt32 _input;
		private CUInt32 _regTime;
		private CUInt32 _inputTime;
		private CUInt32 _instructionTime;
		private CUInt32 _actualTime;
		private CHandle<SecuritySystemControllerPS> _system;
		private CFloat _refreshTime;

		[Ordinal(0)] 
		[RED("lastInstruction")] 
		public CEnum<EReprimandInstructions> LastInstruction
		{
			get
			{
				if (_lastInstruction == null)
				{
					_lastInstruction = (CEnum<EReprimandInstructions>) CR2WTypeManager.Create("EReprimandInstructions", "lastInstruction", cr2w, this);
				}
				return _lastInstruction;
			}
			set
			{
				if (_lastInstruction == value)
				{
					return;
				}
				_lastInstruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instructionSet")] 
		public CBool InstructionSet
		{
			get
			{
				if (_instructionSet == null)
				{
					_instructionSet = (CBool) CR2WTypeManager.Create("Bool", "instructionSet", cr2w, this);
				}
				return _instructionSet;
			}
			set
			{
				if (_instructionSet == value)
				{
					return;
				}
				_instructionSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lastInstructionTime")] 
		public CFloat LastInstructionTime
		{
			get
			{
				if (_lastInstructionTime == null)
				{
					_lastInstructionTime = (CFloat) CR2WTypeManager.Create("Float", "lastInstructionTime", cr2w, this);
				}
				return _lastInstructionTime;
			}
			set
			{
				if (_lastInstructionTime == value)
				{
					return;
				}
				_lastInstructionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lastInput")] 
		public CEnum<ESecurityNotificationType> LastInput
		{
			get
			{
				if (_lastInput == null)
				{
					_lastInput = (CEnum<ESecurityNotificationType>) CR2WTypeManager.Create("ESecurityNotificationType", "lastInput", cr2w, this);
				}
				return _lastInput;
			}
			set
			{
				if (_lastInput == value)
				{
					return;
				}
				_lastInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("inputSet")] 
		public CBool InputSet
		{
			get
			{
				if (_inputSet == null)
				{
					_inputSet = (CBool) CR2WTypeManager.Create("Bool", "inputSet", cr2w, this);
				}
				return _inputSet;
			}
			set
			{
				if (_inputSet == value)
				{
					return;
				}
				_inputSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lastInputTime")] 
		public CFloat LastInputTime
		{
			get
			{
				if (_lastInputTime == null)
				{
					_lastInputTime = (CFloat) CR2WTypeManager.Create("Float", "lastInputTime", cr2w, this);
				}
				return _lastInputTime;
			}
			set
			{
				if (_lastInputTime == value)
				{
					return;
				}
				_lastInputTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lastUpdateTime")] 
		public CFloat LastUpdateTime
		{
			get
			{
				if (_lastUpdateTime == null)
				{
					_lastUpdateTime = (CFloat) CR2WTypeManager.Create("Float", "lastUpdateTime", cr2w, this);
				}
				return _lastUpdateTime;
			}
			set
			{
				if (_lastUpdateTime == value)
				{
					return;
				}
				_lastUpdateTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("realTimeCallbackID")] 
		public gameDelayID RealTimeCallbackID
		{
			get
			{
				if (_realTimeCallbackID == null)
				{
					_realTimeCallbackID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "realTimeCallbackID", cr2w, this);
				}
				return _realTimeCallbackID;
			}
			set
			{
				if (_realTimeCallbackID == value)
				{
					return;
				}
				_realTimeCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("realTimeCallback")] 
		public CBool RealTimeCallback
		{
			get
			{
				if (_realTimeCallback == null)
				{
					_realTimeCallback = (CBool) CR2WTypeManager.Create("Bool", "realTimeCallback", cr2w, this);
				}
				return _realTimeCallback;
			}
			set
			{
				if (_realTimeCallback == value)
				{
					return;
				}
				_realTimeCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("realTime")] 
		public CFloat RealTime
		{
			get
			{
				if (_realTime == null)
				{
					_realTime = (CFloat) CR2WTypeManager.Create("Float", "realTime", cr2w, this);
				}
				return _realTime;
			}
			set
			{
				if (_realTime == value)
				{
					return;
				}
				_realTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("callstack")] 
		public CArray<CName> Callstack
		{
			get
			{
				if (_callstack == null)
				{
					_callstack = (CArray<CName>) CR2WTypeManager.Create("array:CName", "callstack", cr2w, this);
				}
				return _callstack;
			}
			set
			{
				if (_callstack == value)
				{
					return;
				}
				_callstack = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ids")] 
		public CArray<CUInt32> Ids
		{
			get
			{
				if (_ids == null)
				{
					_ids = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "ids", cr2w, this);
				}
				return _ids;
			}
			set
			{
				if (_ids == value)
				{
					return;
				}
				_ids = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("background")] 
		public CUInt32 Background
		{
			get
			{
				if (_background == null)
				{
					_background = (CUInt32) CR2WTypeManager.Create("Uint32", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("sysName")] 
		public CUInt32 SysName
		{
			get
			{
				if (_sysName == null)
				{
					_sysName = (CUInt32) CR2WTypeManager.Create("Uint32", "sysName", cr2w, this);
				}
				return _sysName;
			}
			set
			{
				if (_sysName == value)
				{
					return;
				}
				_sysName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("sysState")] 
		public CUInt32 SysState
		{
			get
			{
				if (_sysState == null)
				{
					_sysState = (CUInt32) CR2WTypeManager.Create("Uint32", "sysState", cr2w, this);
				}
				return _sysState;
			}
			set
			{
				if (_sysState == value)
				{
					return;
				}
				_sysState = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("mostDangerousArea")] 
		public CUInt32 MostDangerousArea
		{
			get
			{
				if (_mostDangerousArea == null)
				{
					_mostDangerousArea = (CUInt32) CR2WTypeManager.Create("Uint32", "mostDangerousArea", cr2w, this);
				}
				return _mostDangerousArea;
			}
			set
			{
				if (_mostDangerousArea == value)
				{
					return;
				}
				_mostDangerousArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("blacklistReason")] 
		public CUInt32 BlacklistReason
		{
			get
			{
				if (_blacklistReason == null)
				{
					_blacklistReason = (CUInt32) CR2WTypeManager.Create("Uint32", "blacklistReason", cr2w, this);
				}
				return _blacklistReason;
			}
			set
			{
				if (_blacklistReason == value)
				{
					return;
				}
				_blacklistReason = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("blacklistCount")] 
		public CUInt32 BlacklistCount
		{
			get
			{
				if (_blacklistCount == null)
				{
					_blacklistCount = (CUInt32) CR2WTypeManager.Create("Uint32", "blacklistCount", cr2w, this);
				}
				return _blacklistCount;
			}
			set
			{
				if (_blacklistCount == value)
				{
					return;
				}
				_blacklistCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("reprimand")] 
		public CUInt32 Reprimand
		{
			get
			{
				if (_reprimand == null)
				{
					_reprimand = (CUInt32) CR2WTypeManager.Create("Uint32", "reprimand", cr2w, this);
				}
				return _reprimand;
			}
			set
			{
				if (_reprimand == value)
				{
					return;
				}
				_reprimand = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("repInstruction")] 
		public CUInt32 RepInstruction
		{
			get
			{
				if (_repInstruction == null)
				{
					_repInstruction = (CUInt32) CR2WTypeManager.Create("Uint32", "repInstruction", cr2w, this);
				}
				return _repInstruction;
			}
			set
			{
				if (_repInstruction == value)
				{
					return;
				}
				_repInstruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("reprimandID")] 
		public CUInt32 ReprimandID
		{
			get
			{
				if (_reprimandID == null)
				{
					_reprimandID = (CUInt32) CR2WTypeManager.Create("Uint32", "reprimandID", cr2w, this);
				}
				return _reprimandID;
			}
			set
			{
				if (_reprimandID == value)
				{
					return;
				}
				_reprimandID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("input")] 
		public CUInt32 Input
		{
			get
			{
				if (_input == null)
				{
					_input = (CUInt32) CR2WTypeManager.Create("Uint32", "input", cr2w, this);
				}
				return _input;
			}
			set
			{
				if (_input == value)
				{
					return;
				}
				_input = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("regTime")] 
		public CUInt32 RegTime
		{
			get
			{
				if (_regTime == null)
				{
					_regTime = (CUInt32) CR2WTypeManager.Create("Uint32", "regTime", cr2w, this);
				}
				return _regTime;
			}
			set
			{
				if (_regTime == value)
				{
					return;
				}
				_regTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("inputTime")] 
		public CUInt32 InputTime
		{
			get
			{
				if (_inputTime == null)
				{
					_inputTime = (CUInt32) CR2WTypeManager.Create("Uint32", "inputTime", cr2w, this);
				}
				return _inputTime;
			}
			set
			{
				if (_inputTime == value)
				{
					return;
				}
				_inputTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("instructionTime")] 
		public CUInt32 InstructionTime
		{
			get
			{
				if (_instructionTime == null)
				{
					_instructionTime = (CUInt32) CR2WTypeManager.Create("Uint32", "instructionTime", cr2w, this);
				}
				return _instructionTime;
			}
			set
			{
				if (_instructionTime == value)
				{
					return;
				}
				_instructionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("actualTime")] 
		public CUInt32 ActualTime
		{
			get
			{
				if (_actualTime == null)
				{
					_actualTime = (CUInt32) CR2WTypeManager.Create("Uint32", "actualTime", cr2w, this);
				}
				return _actualTime;
			}
			set
			{
				if (_actualTime == value)
				{
					return;
				}
				_actualTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get
			{
				if (_system == null)
				{
					_system = (CHandle<SecuritySystemControllerPS>) CR2WTypeManager.Create("handle:SecuritySystemControllerPS", "system", cr2w, this);
				}
				return _system;
			}
			set
			{
				if (_system == value)
				{
					return;
				}
				_system = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("refreshTime")] 
		public CFloat RefreshTime
		{
			get
			{
				if (_refreshTime == null)
				{
					_refreshTime = (CFloat) CR2WTypeManager.Create("Float", "refreshTime", cr2w, this);
				}
				return _refreshTime;
			}
			set
			{
				if (_refreshTime == value)
				{
					return;
				}
				_refreshTime = value;
				PropertySet(this);
			}
		}

		public SecSystemDebugger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
