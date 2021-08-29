using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIGenericEntityLookatTask : AIGenericLookatTask
	{
		private CHandle<entLookAtAddEvent> _lookAtEvent;
		private CFloat _activationTimeStamp;
		private CWeakHandle<entEntity> _lookatTarget;

		[Ordinal(0)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get => GetProperty(ref _lookAtEvent);
			set => SetProperty(ref _lookAtEvent, value);
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}

		[Ordinal(2)] 
		[RED("lookatTarget")] 
		public CWeakHandle<entEntity> LookatTarget
		{
			get => GetProperty(ref _lookatTarget);
			set => SetProperty(ref _lookatTarget, value);
		}
	}
}
