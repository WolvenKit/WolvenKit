using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Zoom : animAnimFeature
	{
		private CFloat _finalZoomLevel;
		private CFloat _weaponZoomLevel;
		private CFloat _weaponAimFOV;
		private CFloat _worldFOV;
		private CInt32 _zoomLevelNum;
		private CFloat _noWeaponAimInTime;
		private CFloat _noWeaponAimOutTime;
		private CBool _shouldUseWeaponZoomStats;
		private CBool _focusModeActive;
		private CFloat _weaponScopeFov;

		[Ordinal(0)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get => GetProperty(ref _finalZoomLevel);
			set => SetProperty(ref _finalZoomLevel, value);
		}

		[Ordinal(1)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get => GetProperty(ref _weaponZoomLevel);
			set => SetProperty(ref _weaponZoomLevel, value);
		}

		[Ordinal(2)] 
		[RED("weaponAimFOV")] 
		public CFloat WeaponAimFOV
		{
			get => GetProperty(ref _weaponAimFOV);
			set => SetProperty(ref _weaponAimFOV, value);
		}

		[Ordinal(3)] 
		[RED("worldFOV")] 
		public CFloat WorldFOV
		{
			get => GetProperty(ref _worldFOV);
			set => SetProperty(ref _worldFOV, value);
		}

		[Ordinal(4)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get => GetProperty(ref _zoomLevelNum);
			set => SetProperty(ref _zoomLevelNum, value);
		}

		[Ordinal(5)] 
		[RED("noWeaponAimInTime")] 
		public CFloat NoWeaponAimInTime
		{
			get => GetProperty(ref _noWeaponAimInTime);
			set => SetProperty(ref _noWeaponAimInTime, value);
		}

		[Ordinal(6)] 
		[RED("noWeaponAimOutTime")] 
		public CFloat NoWeaponAimOutTime
		{
			get => GetProperty(ref _noWeaponAimOutTime);
			set => SetProperty(ref _noWeaponAimOutTime, value);
		}

		[Ordinal(7)] 
		[RED("shouldUseWeaponZoomStats")] 
		public CBool ShouldUseWeaponZoomStats
		{
			get => GetProperty(ref _shouldUseWeaponZoomStats);
			set => SetProperty(ref _shouldUseWeaponZoomStats, value);
		}

		[Ordinal(8)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get => GetProperty(ref _focusModeActive);
			set => SetProperty(ref _focusModeActive, value);
		}

		[Ordinal(9)] 
		[RED("weaponScopeFov")] 
		public CFloat WeaponScopeFov
		{
			get => GetProperty(ref _weaponScopeFov);
			set => SetProperty(ref _weaponScopeFov, value);
		}
	}
}
