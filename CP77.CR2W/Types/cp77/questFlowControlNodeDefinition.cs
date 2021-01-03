using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questFlowControlNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("closesAt")] public CUInt16 ClosesAt { get; set; }
		[Ordinal(1)]  [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(2)]  [RED("opensAt")] public CUInt16 OpensAt { get; set; }

		public questFlowControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
