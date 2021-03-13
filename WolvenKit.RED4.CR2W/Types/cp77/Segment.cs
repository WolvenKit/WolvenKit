using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Segment : CVariable
	{
		[Ordinal(0)] [RED("origin")] public Vector4 Origin { get; set; }
		[Ordinal(1)] [RED("direction")] public Vector4 Direction { get; set; }

		public Segment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
