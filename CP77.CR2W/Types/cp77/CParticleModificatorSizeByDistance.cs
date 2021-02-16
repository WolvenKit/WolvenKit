using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorSizeByDistance : IParticleModificator
	{
		[Ordinal(4)] [RED("nearDistanceRangeStart")] public CHandle<IEvaluatorFloat> NearDistanceRangeStart { get; set; }
		[Ordinal(5)] [RED("nearDistanceRangeEnd")] public CHandle<IEvaluatorFloat> NearDistanceRangeEnd { get; set; }
		[Ordinal(6)] [RED("nearDistanceSizeMultiplier")] public CHandle<IEvaluatorFloat> NearDistanceSizeMultiplier { get; set; }
		[Ordinal(7)] [RED("farDistanceRangeStart")] public CHandle<IEvaluatorFloat> FarDistanceRangeStart { get; set; }
		[Ordinal(8)] [RED("farDistanceRangeEnd")] public CHandle<IEvaluatorFloat> FarDistanceRangeEnd { get; set; }
		[Ordinal(9)] [RED("farDistanceSizeMultiplier")] public CHandle<IEvaluatorFloat> FarDistanceSizeMultiplier { get; set; }

		public CParticleModificatorSizeByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
