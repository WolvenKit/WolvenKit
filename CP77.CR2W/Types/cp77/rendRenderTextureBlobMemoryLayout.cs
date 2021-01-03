using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobMemoryLayout : CVariable
	{
		[Ordinal(0)]  [RED("rowPitch")] public CUInt32 RowPitch { get; set; }
		[Ordinal(1)]  [RED("slicePitch")] public CUInt32 SlicePitch { get; set; }

		public rendRenderTextureBlobMemoryLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
