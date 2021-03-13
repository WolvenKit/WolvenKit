using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSceneAnimationMotionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("params")] public CHandle<AIArgumentMapping> Params { get; set; }
		[Ordinal(2)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }

		public AIbehaviorActionSceneAnimationMotionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
