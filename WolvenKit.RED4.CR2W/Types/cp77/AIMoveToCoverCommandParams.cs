using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCoverCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] [RED("coverNodeRef")] public NodeRef CoverNodeRef { get; set; }
		[Ordinal(1)] [RED("alwaysUseStealth")] public CBool AlwaysUseStealth { get; set; }
		[Ordinal(2)] [RED("specialAction")] public CEnum<ECoverSpecialAction> SpecialAction { get; set; }

		public AIMoveToCoverCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
