using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetUIGameContext_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("requestType")] public CEnum<questUIGameContextRequestType> RequestType { get; set; }
		[Ordinal(1)] [RED("context")] public CEnum<UIGameContext> Context { get; set; }

		public questSetUIGameContext_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
