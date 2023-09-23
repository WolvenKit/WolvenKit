using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionBlinkingStatusRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("lockPreventionSystemWhileBlinking")] 
		public CBool LockPreventionSystemWhileBlinking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("telemetryInfo")] 
		public CString TelemetryInfo
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public PreventionBlinkingStatusRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
