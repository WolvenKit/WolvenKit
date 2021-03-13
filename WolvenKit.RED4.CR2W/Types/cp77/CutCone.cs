using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CutCone : CVariable
	{
		[Ordinal(0)] [RED("positionAndRadius1")] public Vector4 PositionAndRadius1 { get; set; }
		[Ordinal(1)] [RED("normalAndRadius2")] public Vector4 NormalAndRadius2 { get; set; }
		[Ordinal(2)] [RED("height")] public CFloat Height { get; set; }

		public CutCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
