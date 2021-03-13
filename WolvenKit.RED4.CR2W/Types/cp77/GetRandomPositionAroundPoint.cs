using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetRandomPositionAroundPoint : AIRandomTasks
	{
		[Ordinal(0)] [RED("originPoint")] public CHandle<AIArgumentMapping> OriginPoint { get; set; }
		[Ordinal(1)] [RED("distanceMin")] public CHandle<AIArgumentMapping> DistanceMin { get; set; }
		[Ordinal(2)] [RED("distanceMax")] public CHandle<AIArgumentMapping> DistanceMax { get; set; }
		[Ordinal(3)] [RED("angleMin")] public CHandle<AIArgumentMapping> AngleMin { get; set; }
		[Ordinal(4)] [RED("angleMax")] public CHandle<AIArgumentMapping> AngleMax { get; set; }
		[Ordinal(5)] [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
		[Ordinal(6)] [RED("finalPosition")] public Vector4 FinalPosition { get; set; }

		public GetRandomPositionAroundPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
