using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_AnimatedDevice : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isOff")] 
		public CBool IsOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_AnimatedDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
