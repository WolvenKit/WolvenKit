using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FilterRadioGroup : inkRadioGroupController
	{
		[Ordinal(0)]  [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(1)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(2)]  [RED("TooltipIndex")] public CInt32 TooltipIndex { get; set; }
		[Ordinal(3)]  [RED("toggles")] public CArray<wCHandle<inkToggleController>> Toggles { get; set; }
		[Ordinal(4)]  [RED("rootRef")] public wCHandle<inkCompoundWidget> RootRef { get; set; }

		public FilterRadioGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
