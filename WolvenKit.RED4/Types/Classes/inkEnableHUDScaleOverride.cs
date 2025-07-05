using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkEnableHUDScaleOverride : inkInitializedWidgetUserData
	{
		[Ordinal(0)] 
		[RED("scalingInterpolationValue")] 
		public CFloat ScalingInterpolationValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkEnableHUDScaleOverride()
		{
			ScalingInterpolationValue = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
