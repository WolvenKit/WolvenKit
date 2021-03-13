using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entColliderComponentConvex : entColliderComponentShape
	{
		[Ordinal(1)] [RED("mesh")] public rRef<CMesh> Mesh { get; set; }

		public entColliderComponentConvex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
