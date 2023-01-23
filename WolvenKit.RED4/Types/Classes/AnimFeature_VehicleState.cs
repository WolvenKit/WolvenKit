using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_VehicleState : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] 
		[RED("tppEnabled")] 
		public CBool TppEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_VehicleState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
