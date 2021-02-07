using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationComponent : entIComponent
	{
		[Ordinal(0)]  [RED("vertexAnimationMapper")] public entVertexAnimationMapper VertexAnimationMapper { get; set; }
		[Ordinal(1)]  [RED("animatedComponent")] public CHandle<entISourceBinding> AnimatedComponent { get; set; }

		public entVertexAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
