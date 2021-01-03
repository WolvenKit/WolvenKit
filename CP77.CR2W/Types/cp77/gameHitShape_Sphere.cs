using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_Sphere : gameHitShapeBase
	{
		[Ordinal(0)]  [RED("radius")] public CFloat Radius { get; set; }

		public gameHitShape_Sphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
