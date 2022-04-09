using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_VehiclePassengerAnimSetup : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("enableAdditiveAnim")] 
		public CBool EnableAdditiveAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("additiveScale")] 
		public CFloat AdditiveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_VehiclePassengerAnimSetup()
		{
			EnableAdditiveAnim = true;
			AdditiveScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
