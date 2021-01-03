using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldWorldEnvironmentParameters : CVariable
	{
		[Ordinal(0)]  [RED("globalLightingTrajectory")] public GlobalLightingTrajectory GlobalLightingTrajectory { get; set; }

		public worldWorldEnvironmentParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
