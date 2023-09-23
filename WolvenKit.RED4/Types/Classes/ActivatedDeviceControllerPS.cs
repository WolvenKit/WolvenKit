using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("animationSetup")] 
		public ActivatedDeviceAnimSetup AnimationSetup
		{
			get => GetPropertyValue<ActivatedDeviceAnimSetup>();
			set => SetPropertyValue<ActivatedDeviceAnimSetup>(value);
		}

		[Ordinal(108)] 
		[RED("activatedDeviceSetup")] 
		public ActivatedDeviceSetup ActivatedDeviceSetup
		{
			get => GetPropertyValue<ActivatedDeviceSetup>();
			set => SetPropertyValue<ActivatedDeviceSetup>(value);
		}

		[Ordinal(109)] 
		[RED("spiderbotInteractionLocationOverride")] 
		public NodeRef SpiderbotInteractionLocationOverride
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(110)] 
		[RED("industrialArmAnimationOverride")] 
		public CInt32 IndustrialArmAnimationOverride
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ActivatedDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
