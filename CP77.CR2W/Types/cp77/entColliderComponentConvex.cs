using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entColliderComponentConvex : entColliderComponentShape
	{
		[Ordinal(0)]  [RED("mesh")] public rRef<CMesh> Mesh { get; set; }

		public entColliderComponentConvex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
