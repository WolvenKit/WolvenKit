using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICoverDataDef : AIBlackboardDef
	{
		private gamebbScriptID_CName _exposureMethod;
		private gamebbScriptID_CName _fallbackExposureMethod;
		private gamebbScriptID_Uint32 _lastAvailableMethods;
		private gamebbScriptID_Bool _currentlyExposed;
		private gamebbScriptID_Variant _commandExposureMethods;
		private gamebbScriptID_Bool _commandCoverOverride;
		private gamebbScriptID_CName _currentCoverStance;
		private gamebbScriptID_CName _desiredCoverStance;
		private gamebbScriptID_CName _lastCoverPreset;
		private gamebbScriptID_CName _lastInitialCoverPreset;
		private gamebbScriptID_Float _lastCoverChangeThreshold;
		private gamebbScriptID_Float _lastVisibilityCheckTimestamp;
		private gamebbScriptID_Variant _currentRing;
		private gamebbScriptID_Variant _lastCoverRing;
		private gamebbScriptID_Int32 _lastDebugCoverPreset;
		private gamebbScriptID_Bool _firstCoverEvaluationDone;
		private gamebbScriptID_Float _startCoverEvaluationTimeStamp;

		[Ordinal(0)] 
		[RED("exposureMethod")] 
		public gamebbScriptID_CName ExposureMethod
		{
			get => GetProperty(ref _exposureMethod);
			set => SetProperty(ref _exposureMethod, value);
		}

		[Ordinal(1)] 
		[RED("fallbackExposureMethod")] 
		public gamebbScriptID_CName FallbackExposureMethod
		{
			get => GetProperty(ref _fallbackExposureMethod);
			set => SetProperty(ref _fallbackExposureMethod, value);
		}

		[Ordinal(2)] 
		[RED("lastAvailableMethods")] 
		public gamebbScriptID_Uint32 LastAvailableMethods
		{
			get => GetProperty(ref _lastAvailableMethods);
			set => SetProperty(ref _lastAvailableMethods, value);
		}

		[Ordinal(3)] 
		[RED("currentlyExposed")] 
		public gamebbScriptID_Bool CurrentlyExposed
		{
			get => GetProperty(ref _currentlyExposed);
			set => SetProperty(ref _currentlyExposed, value);
		}

		[Ordinal(4)] 
		[RED("commandExposureMethods")] 
		public gamebbScriptID_Variant CommandExposureMethods
		{
			get => GetProperty(ref _commandExposureMethods);
			set => SetProperty(ref _commandExposureMethods, value);
		}

		[Ordinal(5)] 
		[RED("commandCoverOverride")] 
		public gamebbScriptID_Bool CommandCoverOverride
		{
			get => GetProperty(ref _commandCoverOverride);
			set => SetProperty(ref _commandCoverOverride, value);
		}

		[Ordinal(6)] 
		[RED("currentCoverStance")] 
		public gamebbScriptID_CName CurrentCoverStance
		{
			get => GetProperty(ref _currentCoverStance);
			set => SetProperty(ref _currentCoverStance, value);
		}

		[Ordinal(7)] 
		[RED("desiredCoverStance")] 
		public gamebbScriptID_CName DesiredCoverStance
		{
			get => GetProperty(ref _desiredCoverStance);
			set => SetProperty(ref _desiredCoverStance, value);
		}

		[Ordinal(8)] 
		[RED("lastCoverPreset")] 
		public gamebbScriptID_CName LastCoverPreset
		{
			get => GetProperty(ref _lastCoverPreset);
			set => SetProperty(ref _lastCoverPreset, value);
		}

		[Ordinal(9)] 
		[RED("lastInitialCoverPreset")] 
		public gamebbScriptID_CName LastInitialCoverPreset
		{
			get => GetProperty(ref _lastInitialCoverPreset);
			set => SetProperty(ref _lastInitialCoverPreset, value);
		}

		[Ordinal(10)] 
		[RED("lastCoverChangeThreshold")] 
		public gamebbScriptID_Float LastCoverChangeThreshold
		{
			get => GetProperty(ref _lastCoverChangeThreshold);
			set => SetProperty(ref _lastCoverChangeThreshold, value);
		}

		[Ordinal(11)] 
		[RED("lastVisibilityCheckTimestamp")] 
		public gamebbScriptID_Float LastVisibilityCheckTimestamp
		{
			get => GetProperty(ref _lastVisibilityCheckTimestamp);
			set => SetProperty(ref _lastVisibilityCheckTimestamp, value);
		}

		[Ordinal(12)] 
		[RED("currentRing")] 
		public gamebbScriptID_Variant CurrentRing
		{
			get => GetProperty(ref _currentRing);
			set => SetProperty(ref _currentRing, value);
		}

		[Ordinal(13)] 
		[RED("lastCoverRing")] 
		public gamebbScriptID_Variant LastCoverRing
		{
			get => GetProperty(ref _lastCoverRing);
			set => SetProperty(ref _lastCoverRing, value);
		}

		[Ordinal(14)] 
		[RED("lastDebugCoverPreset")] 
		public gamebbScriptID_Int32 LastDebugCoverPreset
		{
			get => GetProperty(ref _lastDebugCoverPreset);
			set => SetProperty(ref _lastDebugCoverPreset, value);
		}

		[Ordinal(15)] 
		[RED("firstCoverEvaluationDone")] 
		public gamebbScriptID_Bool FirstCoverEvaluationDone
		{
			get => GetProperty(ref _firstCoverEvaluationDone);
			set => SetProperty(ref _firstCoverEvaluationDone, value);
		}

		[Ordinal(16)] 
		[RED("startCoverEvaluationTimeStamp")] 
		public gamebbScriptID_Float StartCoverEvaluationTimeStamp
		{
			get => GetProperty(ref _startCoverEvaluationTimeStamp);
			set => SetProperty(ref _startCoverEvaluationTimeStamp, value);
		}
	}
}
