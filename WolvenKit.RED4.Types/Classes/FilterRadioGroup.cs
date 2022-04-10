using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilterRadioGroup : inkRadioGroupController
	{
		[Ordinal(5)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(6)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(7)] 
		[RED("TooltipIndex")] 
		public CInt32 TooltipIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("toggles")] 
		public CArray<CWeakHandle<inkToggleController>> Toggles
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkToggleController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkToggleController>>>(value);
		}

		[Ordinal(9)] 
		[RED("rootRef")] 
		public CWeakHandle<inkCompoundWidget> RootRef
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		public FilterRadioGroup()
		{
			LibraryPath = new() { WidgetLibrary = new() };
			Toggles = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
