using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SceneGameplayOverrides : animAnimFeature
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

		public AnimFeature_SceneGameplayOverrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
