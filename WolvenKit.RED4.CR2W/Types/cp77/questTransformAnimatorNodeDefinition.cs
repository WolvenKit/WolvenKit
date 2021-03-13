using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(3)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(4)] [RED("action")] public CHandle<questTransformAnimatorNode_ActionType> Action { get; set; }

		public questTransformAnimatorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
