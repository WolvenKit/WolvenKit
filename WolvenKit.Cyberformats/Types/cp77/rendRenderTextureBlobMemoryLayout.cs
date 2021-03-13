using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobMemoryLayout : CVariable
	{
		[Ordinal(0)] [RED("rowPitch")] public CUInt32 RowPitch { get; set; }
		[Ordinal(1)] [RED("slicePitch")] public CUInt32 SlicePitch { get; set; }

		public rendRenderTextureBlobMemoryLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
