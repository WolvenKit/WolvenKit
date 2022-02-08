using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JumpPod : gameObject
	{
		[Ordinal(40)] 
		[RED("activationLight")] 
		public CHandle<entIVisualComponent> ActivationLight
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("activationTrigger")] 
		public CHandle<entIComponent> ActivationTrigger
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("impulseForward")] 
		public CFloat ImpulseForward
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("impulseRight")] 
		public CFloat ImpulseRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("impulseUp")] 
		public CFloat ImpulseUp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
