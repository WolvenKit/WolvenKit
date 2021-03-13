using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInteriorMapNode : worldNode
	{
		[Ordinal(4)] [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(5)] [RED("coords")] public CUInt64 Coords { get; set; }
		[Ordinal(6)] [RED("buffer")] public serializationDeferredDataBuffer Buffer { get; set; }

		public worldInteriorMapNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
