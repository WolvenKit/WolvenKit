using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyNPCTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("dataTrackingFact")] 
		public CEnum<ENPCTelemetryData> DataTrackingFact
		{
			get => GetPropertyValue<CEnum<ENPCTelemetryData>>();
			set => SetPropertyValue<CEnum<ENPCTelemetryData>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ModifyNPCTelemetryVariable()
		{
			Value = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
