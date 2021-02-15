using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimDataAddress : CVariable
	{
		[Ordinal(0)] [RED("unkIndex")] public CUInt32 UnkIndex { get; set; }
		[Ordinal(1)] [RED("fsetInBytes")] public CUInt32 FsetInBytes { get; set; }
		[Ordinal(2)] [RED("zeInBytes")] public CUInt32 ZeInBytes { get; set; }

		public animAnimDataAddress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
