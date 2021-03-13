using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_ColliderComponent : gameHitShapeBase
	{
		[Ordinal(3)] [RED("componentNames")] public CArray<CName> ComponentNames { get; set; }

		public gameHitShape_ColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
