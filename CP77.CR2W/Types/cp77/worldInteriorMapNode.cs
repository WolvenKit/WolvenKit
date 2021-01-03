using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldInteriorMapNode : worldNode
	{
		[Ordinal(0)]  [RED("buffer")] public serializationDeferredDataBuffer Buffer { get; set; }
		[Ordinal(1)]  [RED("coords")] public CUInt64 Coords { get; set; }
		[Ordinal(2)]  [RED("version")] public CUInt32 Version { get; set; }

		public worldInteriorMapNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
