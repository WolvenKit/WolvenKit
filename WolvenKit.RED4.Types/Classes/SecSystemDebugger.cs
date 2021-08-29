using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecSystemDebugger : gameScriptableSystem
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
			get => GetProperty(ref _lastInstruction);
			set => SetProperty(ref _lastInstruction, value);
		}

		[Ordinal(1)] 
		[RED("instructionSet")] 
		public CBool InstructionSet
		{
			get => GetProperty(ref _instructionSet);
			set => SetProperty(ref _instructionSet, value);
		}

		[Ordinal(2)] 
		[RED("lastInstructionTime")] 
		public CFloat LastInstructionTime
		{
			get => GetProperty(ref _lastInstructionTime);
			set => SetProperty(ref _lastInstructionTime, value);
		}

		[Ordinal(3)] 
		[RED("lastInput")] 
		public CEnum<ESecurityNotificationType> LastInput
		{
			get => GetProperty(ref _lastInput);
			set => SetProperty(ref _lastInput, value);
		}

		[Ordinal(4)] 
		[RED("inputSet")] 
		public CBool InputSet
		{
			get => GetProperty(ref _inputSet);
			set => SetProperty(ref _inputSet, value);
		}

		[Ordinal(5)] 
		[RED("lastInputTime")] 
		public CFloat LastInputTime
		{
			get => GetProperty(ref _lastInputTime);
			set => SetProperty(ref _lastInputTime, value);
		}

		[Ordinal(6)] 
		[RED("lastUpdateTime")] 
		public CFloat LastUpdateTime
		{
			get => GetProperty(ref _lastUpdateTime);
			set => SetProperty(ref _lastUpdateTime, value);
		}

		[Ordinal(7)] 
		[RED("realTimeCallbackID")] 
		public gameDelayID RealTimeCallbackID
		{
			get => GetProperty(ref _realTimeCallbackID);
			set => SetProperty(ref _realTimeCallbackID, value);
		}

		[Ordinal(8)] 
		[RED("realTimeCallback")] 
		public CBool RealTimeCallback
		{
			get => GetProperty(ref _realTimeCallback);
			set => SetProperty(ref _realTimeCallback, value);
		}

		[Ordinal(9)] 
		[RED("realTime")] 
		public CFloat RealTime
		{
			get => GetProperty(ref _realTime);
			set => SetProperty(ref _realTime, value);
		}

		[Ordinal(10)] 
		[RED("callstack")] 
		public CArray<CName> Callstack
		{
			get => GetProperty(ref _callstack);
			set => SetProperty(ref _callstack, value);
		}

		[Ordinal(11)] 
		[RED("ids")] 
		public CArray<CUInt32> Ids
		{
			get => GetProperty(ref _ids);
			set => SetProperty(ref _ids, value);
		}

		[Ordinal(12)] 
		[RED("background")] 
		public CUInt32 Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(13)] 
		[RED("sysName")] 
		public CUInt32 SysName
		{
			get => GetProperty(ref _sysName);
			set => SetProperty(ref _sysName, value);
		}

		[Ordinal(14)] 
		[RED("sysState")] 
		public CUInt32 SysState
		{
			get => GetProperty(ref _sysState);
			set => SetProperty(ref _sysState, value);
		}

		[Ordinal(15)] 
		[RED("mostDangerousArea")] 
		public CUInt32 MostDangerousArea
		{
			get => GetProperty(ref _mostDangerousArea);
			set => SetProperty(ref _mostDangerousArea, value);
		}

		[Ordinal(16)] 
		[RED("blacklistReason")] 
		public CUInt32 BlacklistReason
		{
			get => GetProperty(ref _blacklistReason);
			set => SetProperty(ref _blacklistReason, value);
		}

		[Ordinal(17)] 
		[RED("blacklistCount")] 
		public CUInt32 BlacklistCount
		{
			get => GetProperty(ref _blacklistCount);
			set => SetProperty(ref _blacklistCount, value);
		}

		[Ordinal(18)] 
		[RED("reprimand")] 
		public CUInt32 Reprimand
		{
			get => GetProperty(ref _reprimand);
			set => SetProperty(ref _reprimand, value);
		}

		[Ordinal(19)] 
		[RED("repInstruction")] 
		public CUInt32 RepInstruction
		{
			get => GetProperty(ref _repInstruction);
			set => SetProperty(ref _repInstruction, value);
		}

		[Ordinal(20)] 
		[RED("reprimandID")] 
		public CUInt32 ReprimandID
		{
			get => GetProperty(ref _reprimandID);
			set => SetProperty(ref _reprimandID, value);
		}

		[Ordinal(21)] 
		[RED("input")] 
		public CUInt32 Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}

		[Ordinal(22)] 
		[RED("regTime")] 
		public CUInt32 RegTime
		{
			get => GetProperty(ref _regTime);
			set => SetProperty(ref _regTime, value);
		}

		[Ordinal(23)] 
		[RED("inputTime")] 
		public CUInt32 InputTime
		{
			get => GetProperty(ref _inputTime);
			set => SetProperty(ref _inputTime, value);
		}

		[Ordinal(24)] 
		[RED("instructionTime")] 
		public CUInt32 InstructionTime
		{
			get => GetProperty(ref _instructionTime);
			set => SetProperty(ref _instructionTime, value);
		}

		[Ordinal(25)] 
		[RED("actualTime")] 
		public CUInt32 ActualTime
		{
			get => GetProperty(ref _actualTime);
			set => SetProperty(ref _actualTime, value);
		}

		[Ordinal(26)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get => GetProperty(ref _system);
			set => SetProperty(ref _system, value);
		}

		[Ordinal(27)] 
		[RED("refreshTime")] 
		public CFloat RefreshTime
		{
			get => GetProperty(ref _refreshTime);
			set => SetProperty(ref _refreshTime, value);
		}
	}
}
