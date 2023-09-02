using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICoverDataDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("exposureMethod")] 
		public gamebbScriptID_CName ExposureMethod
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(1)] 
		[RED("fallbackExposureMethod")] 
		public gamebbScriptID_CName FallbackExposureMethod
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(2)] 
		[RED("lastAvailableMethods")] 
		public gamebbScriptID_Uint32 LastAvailableMethods
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(3)] 
		[RED("currentlyExposed")] 
		public gamebbScriptID_Bool CurrentlyExposed
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("commandExposureMethods")] 
		public gamebbScriptID_Variant CommandExposureMethods
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("commandCoverOverride")] 
		public gamebbScriptID_Bool CommandCoverOverride
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("currentCoverStance")] 
		public gamebbScriptID_CName CurrentCoverStance
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(7)] 
		[RED("desiredCoverStance")] 
		public gamebbScriptID_CName DesiredCoverStance
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(8)] 
		[RED("lastCoverPreset")] 
		public gamebbScriptID_CName LastCoverPreset
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(9)] 
		[RED("lastInitialCoverPreset")] 
		public gamebbScriptID_CName LastInitialCoverPreset
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(10)] 
		[RED("lastCoverChangeThreshold")] 
		public gamebbScriptID_Float LastCoverChangeThreshold
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(11)] 
		[RED("lastVisibilityCheckTimestamp")] 
		public gamebbScriptID_Float LastVisibilityCheckTimestamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(12)] 
		[RED("currentRing")] 
		public gamebbScriptID_Variant CurrentRing
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(13)] 
		[RED("lastCoverRing")] 
		public gamebbScriptID_Variant LastCoverRing
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(14)] 
		[RED("lastDebugCoverPreset")] 
		public gamebbScriptID_Int32 LastDebugCoverPreset
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(15)] 
		[RED("firstCoverEvaluationDone")] 
		public gamebbScriptID_Bool FirstCoverEvaluationDone
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(16)] 
		[RED("startCoverEvaluationTimeStamp")] 
		public gamebbScriptID_Float StartCoverEvaluationTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public AICoverDataDef()
		{
			ExposureMethod = new gamebbScriptID_CName();
			FallbackExposureMethod = new gamebbScriptID_CName();
			LastAvailableMethods = new gamebbScriptID_Uint32();
			CurrentlyExposed = new gamebbScriptID_Bool();
			CommandExposureMethods = new gamebbScriptID_Variant();
			CommandCoverOverride = new gamebbScriptID_Bool();
			CurrentCoverStance = new gamebbScriptID_CName();
			DesiredCoverStance = new gamebbScriptID_CName();
			LastCoverPreset = new gamebbScriptID_CName();
			LastInitialCoverPreset = new gamebbScriptID_CName();
			LastCoverChangeThreshold = new gamebbScriptID_Float();
			LastVisibilityCheckTimestamp = new gamebbScriptID_Float();
			CurrentRing = new gamebbScriptID_Variant();
			LastCoverRing = new gamebbScriptID_Variant();
			LastDebugCoverPreset = new gamebbScriptID_Int32();
			FirstCoverEvaluationDone = new gamebbScriptID_Bool();
			StartCoverEvaluationTimeStamp = new gamebbScriptID_Float();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
