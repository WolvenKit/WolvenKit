using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateBaseTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(2)] [RED("angleOffset")] public CHandle<AIArgumentMapping> AngleOffset { get; set; }
		[Ordinal(3)] [RED("angleTolerance")] public CHandle<AIArgumentMapping> AngleTolerance { get; set; }
		[Ordinal(4)] [RED("speed")] public CHandle<AIArgumentMapping> Speed { get; set; }

		public AIbehaviorActionRotateBaseTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
