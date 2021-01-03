using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleSystem : resStreamedResource
	{
		[Ordinal(0)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
		[Ordinal(1)]  [RED("autoHideRange")] public CFloat AutoHideRange { get; set; }
		[Ordinal(2)]  [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(3)]  [RED("emitters")] public CArray<CHandle<CParticleEmitter>> Emitters { get; set; }
		[Ordinal(4)]  [RED("forceDynamicBbox")] public CBool ForceDynamicBbox { get; set; }
		[Ordinal(5)]  [RED("lastLODFadeoutRange")] public CFloat LastLODFadeoutRange { get; set; }
		[Ordinal(6)]  [RED("particleDamage")] public CHandle<ParticleDamage> ParticleDamage { get; set; }
		[Ordinal(7)]  [RED("prewarmingTime")] public CFloat PrewarmingTime { get; set; }
		[Ordinal(8)]  [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(9)]  [RED("visibleThroughWalls")] public CBool VisibleThroughWalls { get; set; }

		public CParticleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
