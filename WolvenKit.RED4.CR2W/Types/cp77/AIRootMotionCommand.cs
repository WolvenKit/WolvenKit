using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRootMotionCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("params")] public CHandle<gameSceneAnimationMotionActionParams> Params { get; set; }

		public AIRootMotionCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
