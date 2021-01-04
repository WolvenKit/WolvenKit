using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSceneAnimationMotionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(1)]  [RED("params")] public CHandle<AIArgumentMapping> Params { get; set; }

		public AIbehaviorActionSceneAnimationMotionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
