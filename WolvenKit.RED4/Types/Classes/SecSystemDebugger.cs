using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecSystemDebugger : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("lastInstruction")] 
		public CEnum<EReprimandInstructions> LastInstruction
		{
			get => GetPropertyValue<CEnum<EReprimandInstructions>>();
			set => SetPropertyValue<CEnum<EReprimandInstructions>>(value);
		}

		[Ordinal(1)] 
		[RED("instructionSet")] 
		public CBool InstructionSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("lastInstructionTime")] 
		public CFloat LastInstructionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lastInput")] 
		public CEnum<ESecurityNotificationType> LastInput
		{
			get => GetPropertyValue<CEnum<ESecurityNotificationType>>();
			set => SetPropertyValue<CEnum<ESecurityNotificationType>>(value);
		}

		[Ordinal(4)] 
		[RED("inputSet")] 
		public CBool InputSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("lastInputTime")] 
		public CFloat LastInputTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("lastUpdateTime")] 
		public CFloat LastUpdateTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("realTimeCallbackID")] 
		public gameDelayID RealTimeCallbackID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(8)] 
		[RED("realTimeCallback")] 
		public CBool RealTimeCallback
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("realTime")] 
		public CFloat RealTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("callstack")] 
		public CArray<CName> Callstack
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(11)] 
		[RED("ids")] 
		public CArray<CUInt32> Ids
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(12)] 
		[RED("background")] 
		public CUInt32 Background
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("sysName")] 
		public CUInt32 SysName
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(14)] 
		[RED("sysState")] 
		public CUInt32 SysState
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("mostDangerousArea")] 
		public CUInt32 MostDangerousArea
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(16)] 
		[RED("blacklistReason")] 
		public CUInt32 BlacklistReason
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(17)] 
		[RED("blacklistCount")] 
		public CUInt32 BlacklistCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("reprimand")] 
		public CUInt32 Reprimand
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(19)] 
		[RED("repInstruction")] 
		public CUInt32 RepInstruction
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(20)] 
		[RED("reprimandID")] 
		public CUInt32 ReprimandID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(21)] 
		[RED("input")] 
		public CUInt32 Input
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(22)] 
		[RED("regTime")] 
		public CUInt32 RegTime
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("inputTime")] 
		public CUInt32 InputTime
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(24)] 
		[RED("instructionTime")] 
		public CUInt32 InstructionTime
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(25)] 
		[RED("actualTime")] 
		public CUInt32 ActualTime
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(26)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get => GetPropertyValue<CHandle<SecuritySystemControllerPS>>();
			set => SetPropertyValue<CHandle<SecuritySystemControllerPS>>(value);
		}

		[Ordinal(27)] 
		[RED("refreshTime")] 
		public CFloat RefreshTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SecSystemDebugger()
		{
			RealTimeCallbackID = new gameDelayID();
			Callstack = new();
			Ids = new();
			RefreshTime = 60.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
