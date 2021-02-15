using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioReverbCrossoverParams : CVariable
	{
		[Ordinal(0)] [RED("dist")] public CFloat Dist { get; set; }
		[Ordinal(1)] [RED("fade")] public CFloat Fade { get; set; }

		public audioReverbCrossoverParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
