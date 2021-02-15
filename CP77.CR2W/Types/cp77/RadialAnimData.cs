using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RadialAnimData : CVariable
	{
		[Ordinal(0)] [RED("hover_in")] public CName Hover_in { get; set; }
		[Ordinal(1)] [RED("hover_out")] public CName Hover_out { get; set; }
		[Ordinal(2)] [RED("cycle_in")] public CName Cycle_in { get; set; }
		[Ordinal(3)] [RED("cycle_out")] public CName Cycle_out { get; set; }

		public RadialAnimData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
