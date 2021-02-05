using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFallbackFrameDesc : CVariable
	{
		[Ordinal(0)]  [RED("rsion")] public CUInt16 Rsion { get; set; }
		[Ordinal(1)]  [RED("pe")] public CUInt16 Pe { get; set; }
		[Ordinal(2)]  [RED("mPositions")] public CUInt16 MPositions { get; set; }
		[Ordinal(3)]  [RED("mRotations")] public CUInt16 MRotations { get; set; }

		public animAnimFallbackFrameDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
