using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimWalkDecisions : LocomotionGroundDecisions
	{
		private CArray<CHandle<redCallbackObject>> _callbackIDs;
		private CBool _isBlocking;
		private CBool _isAiming;
		private CBool _inFocusMode;
		private CBool _isLeftHandChanging;

		[Ordinal(3)] 
		[RED("callbackIDs")] 
		public CArray<CHandle<redCallbackObject>> CallbackIDs
		{
			get => GetProperty(ref _callbackIDs);
			set => SetProperty(ref _callbackIDs, value);
		}

		[Ordinal(4)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get => GetProperty(ref _isBlocking);
			set => SetProperty(ref _isBlocking, value);
		}

		[Ordinal(5)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(6)] 
		[RED("inFocusMode")] 
		public CBool InFocusMode
		{
			get => GetProperty(ref _inFocusMode);
			set => SetProperty(ref _inFocusMode, value);
		}

		[Ordinal(7)] 
		[RED("isLeftHandChanging")] 
		public CBool IsLeftHandChanging
		{
			get => GetProperty(ref _isLeftHandChanging);
			set => SetProperty(ref _isLeftHandChanging, value);
		}
	}
}
