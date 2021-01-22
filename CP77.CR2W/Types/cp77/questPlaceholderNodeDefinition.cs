using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlaceholderNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("clipboardHolder")] public CHandle<ISerializable> ClipboardHolder { get; set; }
		[Ordinal(1)]  [RED("copiedSockets")] public CArray<questPlaceholderNodeSocketInfo> CopiedSockets { get; set; }
		[Ordinal(2)]  [RED("replacedNodeClassName")] public CName ReplacedNodeClassName { get; set; }

		public questPlaceholderNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
