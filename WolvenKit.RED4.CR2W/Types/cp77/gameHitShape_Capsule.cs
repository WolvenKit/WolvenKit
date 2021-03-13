using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_Capsule : gameHitShapeBase
	{
		[Ordinal(3)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(4)] [RED("height")] public CFloat Height { get; set; }

		public gameHitShape_Capsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
