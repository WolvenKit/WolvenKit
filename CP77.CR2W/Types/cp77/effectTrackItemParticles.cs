using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemParticles : effectTrackItem
	{
		[Ordinal(0)]  [RED("alpha")] public effectEffectParameterEvaluatorFloat Alpha { get; set; }
		[Ordinal(1)]  [RED("emissionScale")] public effectEffectParameterEvaluatorFloat EmissionScale { get; set; }
		[Ordinal(2)]  [RED("particleSystem")] public rRef<CParticleSystem> ParticleSystem { get; set; }
		[Ordinal(3)]  [RED("renderLayerMask")] public RenderSceneLayerMask RenderLayerMask { get; set; }
		[Ordinal(4)]  [RED("size")] public effectEffectParameterEvaluatorFloat Size { get; set; }
		[Ordinal(5)]  [RED("soundPositionName")] public CName SoundPositionName { get; set; }
		[Ordinal(6)]  [RED("soundPositionOffset")] public Vector3 SoundPositionOffset { get; set; }
		[Ordinal(7)]  [RED("velocity")] public effectEffectParameterEvaluatorFloat Velocity { get; set; }

		public effectTrackItemParticles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
