using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponAnimFeature_AimPlayer : animAnimFeature_BasicAim
	{
		private CFloat _zoomLevel;
		private CFloat _aimInTime;
		private CFloat _aimOutTime;

		[Ordinal(2)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get => GetProperty(ref _zoomLevel);
			set => SetProperty(ref _zoomLevel, value);
		}

		[Ordinal(3)] 
		[RED("aimInTime")] 
		public CFloat AimInTime
		{
			get => GetProperty(ref _aimInTime);
			set => SetProperty(ref _aimInTime, value);
		}

		[Ordinal(4)] 
		[RED("aimOutTime")] 
		public CFloat AimOutTime
		{
			get => GetProperty(ref _aimOutTime);
			set => SetProperty(ref _aimOutTime, value);
		}

		public gameweaponAnimFeature_AimPlayer()
		{
			_zoomLevel = 1.000000F;
		}
	}
}
