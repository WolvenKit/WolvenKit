using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DroneActionAltitudeOffset : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("desiredOffset")] 
		public CFloat DesiredOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_DroneActionAltitudeOffset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
