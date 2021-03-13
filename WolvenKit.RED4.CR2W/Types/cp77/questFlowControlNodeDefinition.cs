using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFlowControlNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(3)] [RED("opensAt")] public CUInt16 OpensAt { get; set; }
		[Ordinal(4)] [RED("closesAt")] public CUInt16 ClosesAt { get; set; }

		public questFlowControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
