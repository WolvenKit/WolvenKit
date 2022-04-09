using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponAnimFeature_AimPlayer : animAnimFeature_BasicAim
	{
		[Ordinal(2)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("aimInTime")] 
		public CFloat AimInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("aimOutTime")] 
		public CFloat AimOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameweaponAnimFeature_AimPlayer()
		{
			ZoomLevel = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
