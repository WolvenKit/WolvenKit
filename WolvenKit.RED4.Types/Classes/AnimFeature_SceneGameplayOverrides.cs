using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SceneGameplayOverrides : animAnimFeature
	{
		private CBool _aimForced;
		private CBool _safeForced;
		private CBool _isAimOutTimeOverridden;
		private CFloat _aimOutTimeOverride;

		[Ordinal(0)] 
		[RED("aimForced")] 
		public CBool AimForced
		{
			get => GetProperty(ref _aimForced);
			set => SetProperty(ref _aimForced, value);
		}

		[Ordinal(1)] 
		[RED("safeForced")] 
		public CBool SafeForced
		{
			get => GetProperty(ref _safeForced);
			set => SetProperty(ref _safeForced, value);
		}

		[Ordinal(2)] 
		[RED("isAimOutTimeOverridden")] 
		public CBool IsAimOutTimeOverridden
		{
			get => GetProperty(ref _isAimOutTimeOverridden);
			set => SetProperty(ref _isAimOutTimeOverridden, value);
		}

		[Ordinal(3)] 
		[RED("aimOutTimeOverride")] 
		public CFloat AimOutTimeOverride
		{
			get => GetProperty(ref _aimOutTimeOverride);
			set => SetProperty(ref _aimOutTimeOverride, value);
		}
	}
}
