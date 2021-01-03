using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Matrix : CVariable
	{
		[Ordinal(0)]  [RED("W")] public Vector4 W { get; set; }
		[Ordinal(1)]  [RED("X")] public Vector4 X { get; set; }
		[Ordinal(2)]  [RED("Y")] public Vector4 Y { get; set; }
		[Ordinal(3)]  [RED("Z")] public Vector4 Z { get; set; }

		public Matrix(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
