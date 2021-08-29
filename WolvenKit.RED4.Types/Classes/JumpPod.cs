using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JumpPod : gameObject
	{
		private CHandle<entIVisualComponent> _activationLight;
		private CHandle<entIComponent> _activationTrigger;
		private CFloat _impulseForward;
		private CFloat _impulseRight;
		private CFloat _impulseUp;

		[Ordinal(40)] 
		[RED("activationLight")] 
		public CHandle<entIVisualComponent> ActivationLight
		{
			get => GetProperty(ref _activationLight);
			set => SetProperty(ref _activationLight, value);
		}

		[Ordinal(41)] 
		[RED("activationTrigger")] 
		public CHandle<entIComponent> ActivationTrigger
		{
			get => GetProperty(ref _activationTrigger);
			set => SetProperty(ref _activationTrigger, value);
		}

		[Ordinal(42)] 
		[RED("impulseForward")] 
		public CFloat ImpulseForward
		{
			get => GetProperty(ref _impulseForward);
			set => SetProperty(ref _impulseForward, value);
		}

		[Ordinal(43)] 
		[RED("impulseRight")] 
		public CFloat ImpulseRight
		{
			get => GetProperty(ref _impulseRight);
			set => SetProperty(ref _impulseRight, value);
		}

		[Ordinal(44)] 
		[RED("impulseUp")] 
		public CFloat ImpulseUp
		{
			get => GetProperty(ref _impulseUp);
			set => SetProperty(ref _impulseUp, value);
		}
	}
}
