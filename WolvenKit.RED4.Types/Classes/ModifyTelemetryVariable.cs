using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		private CEnum<ETelemetryData> _dataTrackingFact;
		private CInt32 _value;

		[Ordinal(1)] 
		[RED("dataTrackingFact")] 
		public CEnum<ETelemetryData> DataTrackingFact
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
