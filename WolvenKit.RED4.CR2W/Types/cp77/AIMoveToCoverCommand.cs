using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCoverCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("coverNodeRef")] public NodeRef CoverNodeRef { get; set; }
		[Ordinal(8)] [RED("specialAction")] public CEnum<ECoverSpecialAction> SpecialAction { get; set; }

		public AIMoveToCoverCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
