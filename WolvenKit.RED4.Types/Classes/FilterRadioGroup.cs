using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FilterRadioGroup : inkRadioGroupController
	{
		private inkWidgetLibraryReference _libraryPath;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;
		private CInt32 _tooltipIndex;
		private CArray<CWeakHandle<inkToggleController>> _toggles;
		private CWeakHandle<inkCompoundWidget> _rootRef;

		[Ordinal(5)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(6)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
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
		public CArray<CWeakHandle<inkToggleController>> Toggles
		{
			get => GetProperty(ref _toggles);
			set => SetProperty(ref _toggles, value);
		}

		[Ordinal(9)] 
		[RED("rootRef")] 
		public CWeakHandle<inkCompoundWidget> RootRef
		{
			get => GetProperty(ref _rootRef);
			set => SetProperty(ref _rootRef, value);
		}
	}
}
