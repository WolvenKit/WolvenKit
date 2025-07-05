using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceAnimSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ActivatedDeviceAnimSetup()
		{
			AnimationTime = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
