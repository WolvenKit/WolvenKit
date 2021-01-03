using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationComponent : entIComponent
	{
		[Ordinal(0)]  [RED("animatedComponent")] public CHandle<entISourceBinding> AnimatedComponent { get; set; }
		[Ordinal(1)]  [RED("vertexAnimationMapper")] public entVertexAnimationMapper VertexAnimationMapper { get; set; }

		public entVertexAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
