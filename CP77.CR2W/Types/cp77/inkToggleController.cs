using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkToggleController : inkButtonController
	{
		[Ordinal(0)]  [RED("ToggleChanged")] public inkToggleChangedCallback ToggleChanged { get; set; }
		[Ordinal(1)]  [RED("autoToggleOnInput")] public CBool AutoToggleOnInput { get; set; }
		[Ordinal(2)]  [RED("isToggled")] public CBool IsToggled { get; set; }

		public inkToggleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
