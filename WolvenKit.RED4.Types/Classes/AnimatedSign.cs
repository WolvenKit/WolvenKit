using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimatedSign : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_AnimatedDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_AnimatedDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_AnimatedDevice>>(value);
		}

		public AnimatedSign()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
