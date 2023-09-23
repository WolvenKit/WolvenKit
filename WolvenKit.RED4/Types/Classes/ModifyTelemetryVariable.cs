using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("dataTrackingFact")] 
		public CEnum<ETelemetryData> DataTrackingFact
		{
			get => GetPropertyValue<CEnum<ETelemetryData>>();
			set => SetPropertyValue<CEnum<ETelemetryData>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ModifyTelemetryVariable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
