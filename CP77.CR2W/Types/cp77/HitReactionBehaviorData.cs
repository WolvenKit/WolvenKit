using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitReactionBehaviorData : IScriptable
	{
		[Ordinal(0)]  [RED("hitReactionActivationTimeStamp")] public CFloat HitReactionActivationTimeStamp { get; set; }
		[Ordinal(1)]  [RED("hitReactionDuration")] public CFloat HitReactionDuration { get; set; }
		[Ordinal(2)]  [RED("hitReactionType")] public CEnum<animHitReactionType> HitReactionType { get; set; }

		public HitReactionBehaviorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
