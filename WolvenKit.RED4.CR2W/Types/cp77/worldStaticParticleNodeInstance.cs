using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticParticleNodeInstance : worldINodeInstance
	{
		[Ordinal(0)] [RED("renderLayerMask")] public CEnum<RenderSceneLayerMask> RenderLayerMask { get; set; }

		public worldStaticParticleNodeInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
