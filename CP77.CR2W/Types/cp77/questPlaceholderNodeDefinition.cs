using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
