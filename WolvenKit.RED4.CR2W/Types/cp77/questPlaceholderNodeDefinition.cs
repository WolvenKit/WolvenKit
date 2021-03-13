using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlaceholderNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("replacedNodeClassName")] public CName ReplacedNodeClassName { get; set; }
		[Ordinal(3)] [RED("copiedSockets")] public CArray<questPlaceholderNodeSocketInfo> CopiedSockets { get; set; }
		[Ordinal(4)] [RED("clipboardHolder")] public CHandle<ISerializable> ClipboardHolder { get; set; }

		public questPlaceholderNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
