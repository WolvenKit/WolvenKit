using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_ColliderComponent : gameHitShapeBase
	{
		[Ordinal(0)]  [RED("componentNames")] public CArray<CName> ComponentNames { get; set; }

		public gameHitShape_ColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
