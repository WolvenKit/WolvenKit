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
			get
			{
				if (_titleText == null)
				{
					_titleText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleText", cr2w, this);
				}
				return _titleText;
			}
			set
			{
				if (_titleText == value)
				{
					return;
				}
				_titleText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get
			{
				if (_buttonHintsRoot == null)
				{
					_buttonHintsRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsRoot", cr2w, this);
				}
				return _buttonHintsRoot;
			}
			set
			{
				if (_buttonHintsRoot == value)
				{
					return;
				}
				_buttonHintsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rairtyBar")] 
		public inkWidgetReference RairtyBar
		{
			get
			{
				if (_rairtyBar == null)
				{
					_rairtyBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rairtyBar", cr2w, this);
				}
				return _rairtyBar;
			}
			set
			{
				if (_rairtyBar == value)
				{
					return;
				}
				_rairtyBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("weaponSlotsContainer")] 
		public inkCompoundWidgetReference WeaponSlotsContainer
		{
			get
			{
				if (_weaponSlotsContainer == null)
				{
					_weaponSlotsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "weaponSlotsContainer", cr2w, this);
				}
				return _weaponSlotsContainer;
			}
			set
			{
				if (_weaponSlotsContainer == value)
				{
					return;
				}
				_weaponSlotsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("gameData")] 
		public CHandle<gameItemData> GameData
		{
			get
			{
				if (_gameData == null)
				{
					_gameData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "gameData", cr2w, this);
				}
				return _gameData;
			}
			set
			{
				if (_gameData == value)
				{
					return;
				}
				_gameData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get
			{
				if (_buttonOk == null)
				{
					_buttonOk = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonOk", cr2w, this);
				}
				return _buttonOk;
			}
			set
			{
				if (_buttonOk == value)
				{
					return;
				}
				_buttonOk = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get
			{
				if (_buttonCancel == null)
				{
					_buttonCancel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonCancel", cr2w, this);
				}
				return _buttonCancel;
			}
			set
			{
				if (_buttonCancel == value)
				{
					return;
				}
				_buttonCancel = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<BackpackEquipSlotChooserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<BackpackEquipSlotChooserData>) CR2WTypeManager.Create("handle:BackpackEquipSlotChooserData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("selectedSlotIndex")] 
		public CInt32 SelectedSlotIndex
		{
			get
			{
				if (_selectedSlotIndex == null)
				{
					_selectedSlotIndex = (CInt32) CR2WTypeManager.Create("Int32", "selectedSlotIndex", cr2w, this);
				}
				return _selectedSlotIndex;
			}
			set
			{
				if (_selectedSlotIndex == value)
				{
					return;
				}
				_selectedSlotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "tooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get
			{
				if (_comparisonResolver == null)
				{
					_comparisonResolver = (CHandle<ItemPreferredComparisonResolver>) CR2WTypeManager.Create("handle:ItemPreferredComparisonResolver", "comparisonResolver", cr2w, this);
				}
				return _comparisonResolver;
			}
			set
			{
				if (_comparisonResolver == value)
				{
					return;
				}
				_comparisonResolver = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get
			{
				if (_libraryPath == null)
				{
					_libraryPath = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "libraryPath", cr2w, this);
				}
				return _libraryPath;
			}
			set
			{
				if (_libraryPath == value)
				{
					return;
				}
				_libraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("closeData")] 
		public CHandle<BackpackEquipSlotChooserCloseData> CloseData
		{
			get
			{
				if (_closeData == null)
				{
					_closeData = (CHandle<BackpackEquipSlotChooserCloseData>) CR2WTypeManager.Create("handle:BackpackEquipSlotChooserCloseData", "closeData", cr2w, this);
				}
				return _closeData;
			}
			set
			{
				if (_closeData == value)
				{
					return;
				}
				_closeData = value;
				PropertySet(this);
			}
		}

		public BackpackEquipSlotChooserPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
