using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMatrix_ : CVariable
	{
		[Ordinal(0)] [RED("X")] public Vector4 X { get; set; }
		[Ordinal(1)] [RED("Y")] public Vector4 Y { get; set; }
		[Ordinal(2)] [RED("Z")] public Vector4 Z { get; set; }
		[Ordinal(3)] [RED("W")] public Vector4 W { get; set; }

		public CMatrix_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
