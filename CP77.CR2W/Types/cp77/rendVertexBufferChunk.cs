using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendVertexBufferChunk : CVariable
	{
		[Ordinal(0)]  [RED("byteOffsets")] public CStatic<5,Uint32> ByteOffsets { get; set; }
		[Ordinal(1)]  [RED("vertexLayout")] public GpuWrapApiVertexLayoutDesc VertexLayout { get; set; }

		public rendVertexBufferChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
