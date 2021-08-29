using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyNPCTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		private CEnum<ENPCTelemetryData> _dataTrackingFact;
		private CInt32 _value;

		[Ordinal(1)] 
		[RED("dataTrackingFact")] 
		public CEnum<ENPCTelemetryData> DataTrackingFact
		{
			get => GetProperty(ref _dataTrackingFact);
			set => SetProperty(ref _dataTrackingFact, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
