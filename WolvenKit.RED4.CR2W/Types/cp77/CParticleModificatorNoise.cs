using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorNoise : IParticleModificator
	{
		[Ordinal(4)] [RED("amplitude")] public CHandle<IEvaluatorVector> Amplitude { get; set; }
		[Ordinal(5)] [RED("offset")] public CHandle<IEvaluatorVector> Offset { get; set; }
		[Ordinal(6)] [RED("frequency")] public CHandle<IEvaluatorVector> Frequency { get; set; }
		[Ordinal(7)] [RED("changeRate")] public Vector3 ChangeRate { get; set; }
		[Ordinal(8)] [RED("applyToPosition")] public CBool ApplyToPosition { get; set; }
		[Ordinal(9)] [RED("worldSpaceOffset")] public CBool WorldSpaceOffset { get; set; }
		[Ordinal(10)] [RED("noiseType")] public CEnum<ENoiseType> NoiseType { get; set; }

		public CParticleModificatorNoise(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
