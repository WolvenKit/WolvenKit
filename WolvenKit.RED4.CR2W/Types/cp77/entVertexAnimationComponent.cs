using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationComponent : entIComponent
	{
		[Ordinal(3)] [RED("vertexAnimationMapper")] public entVertexAnimationMapper VertexAnimationMapper { get; set; }
		[Ordinal(4)] [RED("animatedComponent")] public CHandle<entISourceBinding> AnimatedComponent { get; set; }

		public entVertexAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
