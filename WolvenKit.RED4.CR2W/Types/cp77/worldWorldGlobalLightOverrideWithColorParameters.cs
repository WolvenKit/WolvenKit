using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldGlobalLightOverrideWithColorParameters : CVariable
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

		public worldWorldGlobalLightOverrideWithColorParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
