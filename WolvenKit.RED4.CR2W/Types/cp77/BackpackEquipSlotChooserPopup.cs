using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserPopup : gameuiWidgetGameController
	{
		private inkTextWidgetReference _titleText;
		private inkWidgetReference _buttonHintsRoot;
		private inkWidgetReference _rairtyBar;
		private inkWidgetReference _root;
		private inkWidgetReference _background;
		private inkCompoundWidgetReference _weaponSlotsContainer;
		private inkWidgetReference _tooltipsManagerRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<gameItemData> _gameData;
		private inkWidgetReference _buttonOk;
		private inkWidgetReference _buttonCancel;
		private CHandle<BackpackEquipSlotChooserData> _data;
		private CInt32 _selectedSlotIndex;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private inkWidgetLibraryReference _libraryPath;
		private CHandle<BackpackEquipSlotChooserCloseData> _closeData;

		[Ordinal(2)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(3)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetProperty(ref _buttonHintsRoot);
			set => SetProperty(ref _buttonHintsRoot, value);
		}

		[Ordinal(4)] 
		[RED("rairtyBar")] 
		public inkWidgetReference RairtyBar
		{
			get => GetProperty(ref _rairtyBar);
			set => SetProperty(ref _rairtyBar, value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(6)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(7)] 
		[RED("weaponSlotsContainer")] 
		public inkCompoundWidgetReference WeaponSlotsContainer
		{
			get => GetProperty(ref _weaponSlotsContainer);
			set => SetProperty(ref _weaponSlotsContainer, value);
		}

		[Ordinal(8)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(10)] 
		[RED("gameData")] 
		public CHandle<gameItemData> GameData
		{
			get => GetProperty(ref _gameData);
			set => SetProperty(ref _gameData, value);
		}

		[Ordinal(11)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get => GetProperty(ref _buttonOk);
			set => SetProperty(ref _buttonOk, value);
		}

		[Ordinal(12)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetProperty(ref _buttonCancel);
			set => SetProperty(ref _buttonCancel, value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<BackpackEquipSlotChooserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(14)] 
		[RED("selectedSlotIndex")] 
		public CInt32 SelectedSlotIndex
		{
			get => GetProperty(ref _selectedSlotIndex);
			set => SetProperty(ref _selectedSlotIndex, value);
		}

		[Ordinal(15)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(16)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(17)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(18)] 
		[RED("closeData")] 
		public CHandle<BackpackEquipSlotChooserCloseData> CloseData
		{
			get => GetProperty(ref _closeData);
			set => SetProperty(ref _closeData, value);
		}

		public BackpackEquipSlotChooserPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
