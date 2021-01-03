using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnNodeSymbol : CVariable
	{
		[Ordinal(0)]  [RED("editorEventId")] public CUInt64 EditorEventId { get; set; }
		[Ordinal(1)]  [RED("editorNodeId")] public scnNodeId EditorNodeId { get; set; }
		[Ordinal(2)]  [RED("nodeId")] public scnNodeId NodeId { get; set; }

		public scnNodeSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
