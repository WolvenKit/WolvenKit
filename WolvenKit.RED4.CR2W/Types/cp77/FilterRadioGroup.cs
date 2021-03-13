using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterRadioGroup : inkRadioGroupController
	{
		[Ordinal(5)] [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(6)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(7)] [RED("TooltipIndex")] public CInt32 TooltipIndex { get; set; }
		[Ordinal(8)] [RED("toggles")] public CArray<wCHandle<inkToggleController>> Toggles { get; set; }
		[Ordinal(9)] [RED("rootRef")] public wCHandle<inkCompoundWidget> RootRef { get; set; }

		public FilterRadioGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
