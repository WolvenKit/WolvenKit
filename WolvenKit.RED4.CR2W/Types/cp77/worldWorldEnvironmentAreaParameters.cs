using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldEnvironmentAreaParameters : CVariable
	{
		[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)] [RED("globalLight")] public worldWorldGlobalLightParameters GlobalLight { get; set; }

		public worldWorldEnvironmentAreaParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
