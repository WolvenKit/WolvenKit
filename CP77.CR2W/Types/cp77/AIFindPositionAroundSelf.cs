using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFindPositionAroundSelf : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("angleOffset")] public CFloat AngleOffset { get; set; }
		[Ordinal(2)]  [RED("distanceMax")] public CHandle<AIArgumentMapping> DistanceMax { get; set; }
		[Ordinal(3)]  [RED("distanceMin")] public CHandle<AIArgumentMapping> DistanceMin { get; set; }
		[Ordinal(4)]  [RED("finalPosition")] public Vector4 FinalPosition { get; set; }
		[Ordinal(5)]  [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }

		public AIFindPositionAroundSelf(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
