using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Point : CVariable
	{
		[Ordinal(0)] [RED("x")] public CInt32 X { get; set; }
		[Ordinal(1)] [RED("y")] public CInt32 Y { get; set; }

		public Point(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
