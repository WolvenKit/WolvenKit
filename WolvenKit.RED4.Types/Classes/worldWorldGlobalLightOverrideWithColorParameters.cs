using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWorldGlobalLightOverrideWithColorParameters : RedBaseClass
	{
		private GlobalLightingTrajectoryOverride _lightDirOverride;
		private HDRColor _lightColorOverride;

		[Ordinal(0)] 
		[RED("lightDirOverride")] 
		public GlobalLightingTrajectoryOverride LightDirOverride
		{
			get => GetProperty(ref _lightDirOverride);
			set => SetProperty(ref _lightDirOverride, value);
		}

		[Ordinal(1)] 
		[RED("lightColorOverride")] 
		public HDRColor LightColorOverride
		{
			get => GetProperty(ref _lightColorOverride);
			set => SetProperty(ref _lightColorOverride, value);
		}
	}
}
