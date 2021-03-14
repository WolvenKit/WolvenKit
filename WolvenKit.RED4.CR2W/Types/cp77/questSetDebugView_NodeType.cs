using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetDebugView_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] [RED("mode")] public CEnum<questEDebugViewMode> Mode { get; set; }

		public questSetDebugView_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
