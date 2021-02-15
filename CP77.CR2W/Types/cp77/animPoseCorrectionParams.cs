using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionParams : CVariable
	{
		[Ordinal(0)] [RED("poseCorrectionGroup")] public animPoseCorrectionGroup PoseCorrectionGroup { get; set; }
		[Ordinal(1)] [RED("blendDuration")] public CFloat BlendDuration { get; set; }

		public animPoseCorrectionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
