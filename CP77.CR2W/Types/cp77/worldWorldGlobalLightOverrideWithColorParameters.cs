using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldWorldGlobalLightOverrideWithColorParameters : CVariable
	{
		[Ordinal(0)]  [RED("lightColorOverride")] public HDRColor LightColorOverride { get; set; }
		[Ordinal(1)]  [RED("lightDirOverride")] public GlobalLightingTrajectoryOverride LightDirOverride { get; set; }

		public worldWorldGlobalLightOverrideWithColorParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
