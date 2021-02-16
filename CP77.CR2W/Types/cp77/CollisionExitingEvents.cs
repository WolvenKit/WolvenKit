using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CollisionExitingEvents : ImmediateExitWithForceEvents
	{
		[Ordinal(6)] [RED("animFeatureStatusEffect")] public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect { get; set; }

		public CollisionExitingEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
