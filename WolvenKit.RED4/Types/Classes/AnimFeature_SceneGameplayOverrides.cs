using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_SceneGameplayOverrides : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("aimForced")] 
		public CBool AimForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("safeForced")] 
		public CBool SafeForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isAimOutTimeOverridden")] 
		public CBool IsAimOutTimeOverridden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("aimOutTimeOverride")] 
		public CFloat AimOutTimeOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_SceneGameplayOverrides()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
