using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("action")] public CHandle<questTransformAnimatorNode_ActionType> Action { get; set; }
		[Ordinal(1)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(2)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questTransformAnimatorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
