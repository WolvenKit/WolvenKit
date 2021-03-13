using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entParticlesComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("emissionRate")] public CFloat EmissionRate { get; set; }
		[Ordinal(9)] [RED("particleSystem")] public rRef<CParticleSystem> ParticleSystem { get; set; }
		[Ordinal(10)] [RED("autoHideRange")] public CFloat AutoHideRange { get; set; }
		[Ordinal(11)] [RED("renderLayerMask")] public CEnum<RenderSceneLayerMask> RenderLayerMask { get; set; }
		[Ordinal(12)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entParticlesComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
