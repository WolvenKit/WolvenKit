using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GlitchData : CVariable
	{
		[Ordinal(0)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(1)]  [RED("state")] public CEnum<EGlitchState> State { get; set; }

		public GlitchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
