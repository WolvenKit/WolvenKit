using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VisionContextDecisions : InputContextTransitionDecisions
	{
		private CHandle<redCallbackObject> _vehicleCallbackID;
		private CHandle<redCallbackObject> _focusCallbackID;
		private CBool _vehicleTransition;
		private CBool _isFocusing;
		private CBool _visionHoldPressed;

		[Ordinal(0)] 
		[RED("vehicleCallbackID")] 
		public CHandle<redCallbackObject> VehicleCallbackID
		{
			get => GetProperty(ref _vehicleCallbackID);
			set => SetProperty(ref _vehicleCallbackID, value);
		}

		[Ordinal(1)] 
		[RED("focusCallbackID")] 
		public CHandle<redCallbackObject> FocusCallbackID
		{
			get => GetProperty(ref _focusCallbackID);
			set => SetProperty(ref _focusCallbackID, value);
		}

		[Ordinal(2)] 
		[RED("vehicleTransition")] 
		public CBool VehicleTransition
		{
			get => GetProperty(ref _vehicleTransition);
			set => SetProperty(ref _vehicleTransition, value);
		}

		[Ordinal(3)] 
		[RED("isFocusing")] 
		public CBool IsFocusing
		{
			get => GetProperty(ref _isFocusing);
			set => SetProperty(ref _isFocusing, value);
		}

		[Ordinal(4)] 
		[RED("visionHoldPressed")] 
		public CBool VisionHoldPressed
		{
			get => GetProperty(ref _visionHoldPressed);
			set => SetProperty(ref _visionHoldPressed, value);
		}
	}
}
