using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimingContextDecisions : InputContextTransitionDecisions
	{
		private CHandle<redCallbackObject> _leftHandChargeCallbackID;
		private CHandle<redCallbackObject> _upperBodyCallbackID;
		private CHandle<redCallbackObject> _meleeCallbackID;
		private CBool _leftHandCharge;
		private CBool _isAiming;
		private CBool _meleeBlockActive;

		[Ordinal(0)] 
		[RED("leftHandChargeCallbackID")] 
		public CHandle<redCallbackObject> LeftHandChargeCallbackID
		{
			get => GetProperty(ref _leftHandChargeCallbackID);
			set => SetProperty(ref _leftHandChargeCallbackID, value);
		}

		[Ordinal(1)] 
		[RED("upperBodyCallbackID")] 
		public CHandle<redCallbackObject> UpperBodyCallbackID
		{
			get => GetProperty(ref _upperBodyCallbackID);
			set => SetProperty(ref _upperBodyCallbackID, value);
		}

		[Ordinal(2)] 
		[RED("meleeCallbackID")] 
		public CHandle<redCallbackObject> MeleeCallbackID
		{
			get => GetProperty(ref _meleeCallbackID);
			set => SetProperty(ref _meleeCallbackID, value);
		}

		[Ordinal(3)] 
		[RED("leftHandCharge")] 
		public CBool LeftHandCharge
		{
			get => GetProperty(ref _leftHandCharge);
			set => SetProperty(ref _leftHandCharge, value);
		}

		[Ordinal(4)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(5)] 
		[RED("meleeBlockActive")] 
		public CBool MeleeBlockActive
		{
			get => GetProperty(ref _meleeBlockActive);
			set => SetProperty(ref _meleeBlockActive, value);
		}
	}
}
