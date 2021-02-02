using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleSystem : resStreamedResource
	{
		[Ordinal(0)]  [RED("emitters")] public CArray<CHandle<CParticleEmitter>> Emitters { get; set; }
		[Ordinal(1)]  [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(2)]  [RED("forceDynamicBbox")] public CBool ForceDynamicBbox { get; set; }
		[Ordinal(3)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
		[Ordinal(4)]  [RED("autoHideRange")] public CFloat AutoHideRange { get; set; }
		[Ordinal(5)]  [RED("lastLODFadeoutRange")] public CFloat LastLODFadeoutRange { get; set; }
		[Ordinal(6)]  [RED("visibleThroughWalls")] public CBool VisibleThroughWalls { get; set; }
		[Ordinal(7)]  [RED("prewarmingTime")] public CFloat PrewarmingTime { get; set; }
		[Ordinal(8)]  [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(9)]  [RED("particleDamage")] public CHandle<ParticleDamage> ParticleDamage { get; set; }

		public CParticleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
