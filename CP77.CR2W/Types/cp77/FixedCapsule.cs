using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FixedCapsule : CVariable
	{
		[Ordinal(0)]  [RED("Height")] public CFloat Height { get; set; }
		[Ordinal(1)]  [RED("PointRadius")] public Vector4 PointRadius { get; set; }

		public FixedCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
