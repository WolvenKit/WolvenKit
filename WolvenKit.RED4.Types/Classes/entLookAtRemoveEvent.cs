using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entLookAtRemoveEvent : redEvent
	{
		private animLookAtRef _lookAtRef;
		private CBool _hasOutTransition;
		private CFloat _outTransitionSpeed;

		[Ordinal(0)] 
		[RED("lookAtRef")] 
		public animLookAtRef LookAtRef
		{
			get => GetProperty(ref _lookAtRef);
			set => SetProperty(ref _lookAtRef, value);
		}

		[Ordinal(1)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get => GetProperty(ref _hasOutTransition);
			set => SetProperty(ref _hasOutTransition, value);
		}

		[Ordinal(2)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetProperty(ref _outTransitionSpeed);
			set => SetProperty(ref _outTransitionSpeed, value);
		}

		public entLookAtRemoveEvent()
		{
			_outTransitionSpeed = 60.000000F;
		}
	}
}
