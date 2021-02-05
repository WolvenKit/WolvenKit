using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorSizeByDistance : IParticleModificator
	{
		[Ordinal(0)]  [RED("nearDistanceRangeStart")] public CHandle<IEvaluatorFloat> NearDistanceRangeStart { get; set; }
		[Ordinal(1)]  [RED("nearDistanceRangeEnd")] public CHandle<IEvaluatorFloat> NearDistanceRangeEnd { get; set; }
		[Ordinal(2)]  [RED("nearDistanceSizeMultiplier")] public CHandle<IEvaluatorFloat> NearDistanceSizeMultiplier { get; set; }
		[Ordinal(3)]  [RED("farDistanceRangeStart")] public CHandle<IEvaluatorFloat> FarDistanceRangeStart { get; set; }
		[Ordinal(4)]  [RED("farDistanceRangeEnd")] public CHandle<IEvaluatorFloat> FarDistanceRangeEnd { get; set; }
		[Ordinal(5)]  [RED("farDistanceSizeMultiplier")] public CHandle<IEvaluatorFloat> FarDistanceSizeMultiplier { get; set; }

		public CParticleModificatorSizeByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
