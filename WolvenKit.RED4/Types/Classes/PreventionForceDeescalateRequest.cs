using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionForceDeescalateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("fakeBlinkingDuration")] 
		public CFloat FakeBlinkingDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("telemetryInfo")] 
		public CString TelemetryInfo
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public PreventionForceDeescalateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
