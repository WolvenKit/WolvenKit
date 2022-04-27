using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_NPCVehicleAdditionalFeatures : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CBool State
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_NPCVehicleAdditionalFeatures()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
