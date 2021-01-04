using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TimeBetweenHitsParameters : CVariable
	{
		[Ordinal(0)]  [RED("accuracyCoefficient")] public CFloat AccuracyCoefficient { get; set; }
		[Ordinal(1)]  [RED("baseCoefficient")] public CFloat BaseCoefficient { get; set; }
		[Ordinal(2)]  [RED("baseSourceCoefficient")] public CFloat BaseSourceCoefficient { get; set; }
		[Ordinal(3)]  [RED("coefficientMultiplier")] public CFloat CoefficientMultiplier { get; set; }
		[Ordinal(4)]  [RED("difficultyLevelCoefficient")] public CFloat DifficultyLevelCoefficient { get; set; }
		[Ordinal(5)]  [RED("distanceCoefficient")] public CFloat DistanceCoefficient { get; set; }
		[Ordinal(6)]  [RED("groupCoefficient")] public CFloat GroupCoefficient { get; set; }
		[Ordinal(7)]  [RED("playersCountCoefficient")] public CFloat PlayersCountCoefficient { get; set; }
		[Ordinal(8)]  [RED("visibilityCoefficient")] public CFloat VisibilityCoefficient { get; set; }

		public TimeBetweenHitsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
