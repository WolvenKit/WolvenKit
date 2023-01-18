using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JumpPod : gameObject
	{
		[Ordinal(35)] 
		[RED("activationLight")] 
		public CHandle<entIVisualComponent> ActivationLight
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		[Ordinal(36)] 
		[RED("activationTrigger")] 
		public CHandle<entIComponent> ActivationTrigger
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("impulseForward")] 
		public CFloat ImpulseForward
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("impulseRight")] 
		public CFloat ImpulseRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("impulseUp")] 
		public CFloat ImpulseUp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public JumpPod()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
