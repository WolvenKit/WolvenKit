using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Segment : CVariable
	{
		[Ordinal(0)]  [RED("direction")] public Vector4 Direction { get; set; }
		[Ordinal(1)]  [RED("origin")] public Vector4 Origin { get; set; }

		public Segment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
