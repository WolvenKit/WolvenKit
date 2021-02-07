using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorNoise : IParticleModificator
	{
		[Ordinal(0)]  [RED("amplitude")] public CHandle<IEvaluatorVector> Amplitude { get; set; }
		[Ordinal(1)]  [RED("offset")] public CHandle<IEvaluatorVector> Offset { get; set; }
		[Ordinal(2)]  [RED("frequency")] public CHandle<IEvaluatorVector> Frequency { get; set; }
		[Ordinal(3)]  [RED("changeRate")] public Vector3 ChangeRate { get; set; }
		[Ordinal(4)]  [RED("applyToPosition")] public CBool ApplyToPosition { get; set; }
		[Ordinal(5)]  [RED("worldSpaceOffset")] public CBool WorldSpaceOffset { get; set; }
		[Ordinal(6)]  [RED("noiseType")] public CEnum<ENoiseType> NoiseType { get; set; }

		public CParticleModificatorNoise(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
