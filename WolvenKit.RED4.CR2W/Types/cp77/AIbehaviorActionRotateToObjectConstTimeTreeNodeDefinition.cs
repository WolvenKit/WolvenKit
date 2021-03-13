using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateToObjectConstTimeTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(2)] [RED("angleOffset")] public CHandle<AIArgumentMapping> AngleOffset { get; set; }
		[Ordinal(3)] [RED("angleTolerance")] public CHandle<AIArgumentMapping> AngleTolerance { get; set; }
		[Ordinal(4)] [RED("time")] public CHandle<AIArgumentMapping> Time { get; set; }
		[Ordinal(5)] [RED("keepUpdatingTarget")] public CHandle<AIArgumentMapping> KeepUpdatingTarget { get; set; }

		public AIbehaviorActionRotateToObjectConstTimeTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
