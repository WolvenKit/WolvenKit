using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameNarrationPlateComponent : entIComponent
	{
		[Ordinal(0)]  [RED("narrationText")] public CName NarrationText { get; set; }
		[Ordinal(1)]  [RED("narrationCaption")] public CName NarrationCaption { get; set; }

		public gameNarrationPlateComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
