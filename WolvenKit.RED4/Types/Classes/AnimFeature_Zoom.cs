using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_Zoom : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("weaponAimFOV")] 
		public CFloat WeaponAimFOV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("worldFOV")] 
		public CFloat WorldFOV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("noWeaponAimInTime")] 
		public CFloat NoWeaponAimInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("noWeaponAimOutTime")] 
		public CFloat NoWeaponAimOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("shouldUseWeaponZoomStats")] 
		public CBool ShouldUseWeaponZoomStats
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("weaponScopeFov")] 
		public CFloat WeaponScopeFov
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_Zoom()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
