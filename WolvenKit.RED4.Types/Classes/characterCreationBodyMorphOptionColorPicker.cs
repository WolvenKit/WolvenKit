using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationBodyMorphOptionColorPicker : inkWidgetLogicController
	{
		private inkUniformGridWidgetReference _grid;
		private inkTextWidgetReference _title;
		private CWeakHandle<gameuiCharacterCustomizationOption> _option;
		private CInt32 _selectedIndex;

		[Ordinal(1)] 
		[RED("grid")] 
		public inkUniformGridWidgetReference Grid
		{
			get => GetProperty(ref _grid);
			set => SetProperty(ref _grid, value);
		}

		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("option")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> Option
		{
			get => GetProperty(ref _option);
			set => SetProperty(ref _option, value);
		}

		[Ordinal(4)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get => GetProperty(ref _selectedIndex);
			set => SetProperty(ref _selectedIndex, value);
		}
	}
}
