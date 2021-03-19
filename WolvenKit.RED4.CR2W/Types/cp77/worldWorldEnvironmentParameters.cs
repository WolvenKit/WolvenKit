using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldEnvironmentParameters : CVariable
	{
		private GlobalLightingTrajectory _globalLightingTrajectory;

		[Ordinal(0)] 
		[RED("globalLightingTrajectory")] 
		public GlobalLightingTrajectory GlobalLightingTrajectory
		{
			get => GetProperty(ref _globalLightingTrajectory);
			set => SetProperty(ref _globalLightingTrajectory, value);
		}

		public worldWorldEnvironmentParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
