using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VisionContextDecisions : InputContextTransitionDecisions
	{
		[Ordinal(0)] 
		[RED("vehicleCallbackID")] 
		public CHandle<redCallbackObject> VehicleCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("focusCallbackID")] 
		public CHandle<redCallbackObject> FocusCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleTransition")] 
		public CBool VehicleTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isFocusing")] 
		public CBool IsFocusing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("visionHoldPressed")] 
		public CBool VisionHoldPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VisionContextDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
