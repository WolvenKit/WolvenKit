using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldWorldEnvironmentAreaParameters : CVariable
	{
		[Ordinal(0)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)]  [RED("globalLight")] public worldWorldGlobalLightParameters GlobalLight { get; set; }

		public worldWorldEnvironmentAreaParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
