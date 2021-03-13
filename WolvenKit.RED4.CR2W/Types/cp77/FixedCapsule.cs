using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FixedCapsule : CVariable
	{
		[Ordinal(0)] [RED("PointRadius")] public Vector4 PointRadius { get; set; }
		[Ordinal(1)] [RED("Height")] public CFloat Height { get; set; }

		public FixedCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
