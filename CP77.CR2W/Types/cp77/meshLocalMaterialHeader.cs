using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshLocalMaterialHeader : CVariable
	{
		[Ordinal(0)] [RED("offset")] public CUInt32 Offset { get; set; }
		[Ordinal(1)] [RED("size")] public CUInt32 Size { get; set; }

		public meshLocalMaterialHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
