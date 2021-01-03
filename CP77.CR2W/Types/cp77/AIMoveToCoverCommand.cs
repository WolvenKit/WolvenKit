using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCoverCommand : AIMoveCommand
	{
		[Ordinal(0)]  [RED("coverNodeRef")] public NodeRef CoverNodeRef { get; set; }
		[Ordinal(1)]  [RED("specialAction")] public CEnum<ECoverSpecialAction> SpecialAction { get; set; }

		public AIMoveToCoverCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
