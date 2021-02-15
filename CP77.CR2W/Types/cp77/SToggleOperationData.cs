using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SToggleOperationData : CVariable
	{
		[Ordinal(0)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(2)] [RED("classType")] public CEnum<EOperationClassType> ClassType { get; set; }

		public SToggleOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
