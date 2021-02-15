using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemParticles : effectTrackItem
	{
		[Ordinal(3)] [RED("particleSystem")] public rRef<CParticleSystem> ParticleSystem { get; set; }
		[Ordinal(4)] [RED("emissionScale")] public effectEffectParameterEvaluatorFloat EmissionScale { get; set; }
		[Ordinal(5)] [RED("alpha")] public effectEffectParameterEvaluatorFloat Alpha { get; set; }
		[Ordinal(6)] [RED("size")] public effectEffectParameterEvaluatorFloat Size { get; set; }
		[Ordinal(7)] [RED("velocity")] public effectEffectParameterEvaluatorFloat Velocity { get; set; }
		[Ordinal(8)] [RED("soundPositionName")] public CName SoundPositionName { get; set; }
		[Ordinal(9)] [RED("soundPositionOffset")] public Vector3 SoundPositionOffset { get; set; }
		[Ordinal(10)] [RED("renderLayerMask")] public CEnum<RenderSceneLayerMask> RenderLayerMask { get; set; }

		public effectTrackItemParticles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
