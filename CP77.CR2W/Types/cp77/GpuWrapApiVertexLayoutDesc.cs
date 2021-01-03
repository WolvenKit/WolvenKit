using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GpuWrapApiVertexLayoutDesc : CVariable
	{
		[Ordinal(0)]  [RED("elements")] public CStatic<32,GpuWrapApiVertexPackingPackingElement> Elements { get; set; }
		[Ordinal(1)]  [RED("hash")] public CUInt32 Hash { get; set; }
		[Ordinal(2)]  [RED("slotMask")] public CUInt32 SlotMask { get; set; }
		[Ordinal(3)]  [RED("slotStrides")] public CStatic<8,Uint8> SlotStrides { get; set; }

		public GpuWrapApiVertexLayoutDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
