using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendVertexBufferChunk : CVariable
	{
		[Ordinal(0)]  [RED("byteOffsets", 5)] public CStatic<CUInt32> ByteOffsets { get; set; }
		[Ordinal(1)]  [RED("vertexLayout")] public GpuWrapApiVertexLayoutDesc VertexLayout { get; set; }

		public rendVertexBufferChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
