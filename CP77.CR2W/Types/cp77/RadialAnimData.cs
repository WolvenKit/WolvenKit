using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RadialAnimData : CVariable
	{
		[Ordinal(0)]  [RED("cycle_in")] public CName Cycle_in { get; set; }
		[Ordinal(1)]  [RED("cycle_out")] public CName Cycle_out { get; set; }
		[Ordinal(2)]  [RED("hover_in")] public CName Hover_in { get; set; }
		[Ordinal(3)]  [RED("hover_out")] public CName Hover_out { get; set; }

		public RadialAnimData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
