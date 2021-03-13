using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnNodeSymbol : CVariable
	{
		[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(1)] [RED("editorNodeId")] public scnNodeId EditorNodeId { get; set; }
		[Ordinal(2)] [RED("editorEventId")] public CUInt64 EditorEventId { get; set; }

		public scnNodeSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
