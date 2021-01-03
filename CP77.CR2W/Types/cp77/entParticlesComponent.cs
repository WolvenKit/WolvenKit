using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entParticlesComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("autoHideRange")] public CFloat AutoHideRange { get; set; }
		[Ordinal(1)]  [RED("emissionRate")] public CFloat EmissionRate { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("particleSystem")] public rRef<CParticleSystem> ParticleSystem { get; set; }
		[Ordinal(4)]  [RED("renderLayerMask")] public RenderSceneLayerMask RenderLayerMask { get; set; }

		public entParticlesComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
