using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterRadioGroup : inkRadioGroupController
	{
		private inkWidgetLibraryReference _libraryPath;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CInt32 _tooltipIndex;
		private CArray<wCHandle<inkToggleController>> _toggles;
		private wCHandle<inkCompoundWidget> _rootRef;

		[Ordinal(5)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(6)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(7)] 
		[RED("TooltipIndex")] 
		public CInt32 TooltipIndex
		{
			get => GetProperty(ref _tooltipIndex);
			set => SetProperty(ref _tooltipIndex, value);
		}

		[Ordinal(8)] 
		[RED("toggles")] 
		public CArray<wCHandle<inkToggleController>> Toggles
		{
			get => GetProperty(ref _toggles);
			set => SetProperty(ref _toggles, value);
		}

		[Ordinal(9)] 
		[RED("rootRef")] 
		public wCHandle<inkCompoundWidget> RootRef
		{
			get => GetProperty(ref _rootRef);
			set => SetProperty(ref _rootRef, value);
		}

		public FilterRadioGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
