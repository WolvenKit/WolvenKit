using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SharedMetaPose : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("weightLink")] public animFloatLink WeightLink { get; set; }

		public animAnimNode_SharedMetaPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
