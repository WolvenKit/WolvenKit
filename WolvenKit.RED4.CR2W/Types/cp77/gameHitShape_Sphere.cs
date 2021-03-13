using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_Sphere : gameHitShapeBase
	{
		[Ordinal(3)] [RED("radius")] public CFloat Radius { get; set; }

		public gameHitShape_Sphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
