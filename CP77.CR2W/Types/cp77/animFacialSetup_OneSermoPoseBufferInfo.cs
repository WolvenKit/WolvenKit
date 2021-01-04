using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_OneSermoPoseBufferInfo : CVariable
	{
		[Ordinal(0)]  [RED("numCorrectivePoses")] public CUInt16 NumCorrectivePoses { get; set; }
		[Ordinal(1)]  [RED("numCorrectiveScales")] public CUInt32 NumCorrectiveScales { get; set; }
		[Ordinal(2)]  [RED("numCorrectiveTransforms")] public CUInt32 NumCorrectiveTransforms { get; set; }
		[Ordinal(3)]  [RED("numMainPoses")] public CUInt16 NumMainPoses { get; set; }
		[Ordinal(4)]  [RED("numMainScales")] public CUInt32 NumMainScales { get; set; }
		[Ordinal(5)]  [RED("numMainTransforms")] public CUInt32 NumMainTransforms { get; set; }

		public animFacialSetup_OneSermoPoseBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
