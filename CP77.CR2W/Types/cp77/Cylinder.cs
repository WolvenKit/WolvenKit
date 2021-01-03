using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Cylinder : CVariable
	{
		[Ordinal(0)]  [RED("normalAndHeight")] public Vector4 NormalAndHeight { get; set; }
		[Ordinal(1)]  [RED("positionAndRadius")] public Vector4 PositionAndRadius { get; set; }

		public Cylinder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
