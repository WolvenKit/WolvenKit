using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PitchSelectorControllerBool : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("yesRef")] 
		public inkWidgetReference YesRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("noRef")] 
		public inkWidgetReference NoRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("localValue")] 
		public CBool LocalValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("telemetryController")] 
		public CWeakHandle<PitchTelemetryMenuGameController> TelemetryController
		{
			get => GetPropertyValue<CWeakHandle<PitchTelemetryMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<PitchTelemetryMenuGameController>>(value);
		}

		public PitchSelectorControllerBool()
		{
			YesRef = new inkWidgetReference();
			NoRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
