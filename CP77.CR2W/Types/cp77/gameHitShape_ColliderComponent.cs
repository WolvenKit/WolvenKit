using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_ColliderComponent : gameHitShapeBase
	{
		[Ordinal(3)] [RED("componentNames")] public CArray<CName> ComponentNames { get; set; }

		public gameHitShape_ColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
