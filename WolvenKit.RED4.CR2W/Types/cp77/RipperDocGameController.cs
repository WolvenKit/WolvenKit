using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperDocGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _defaultTab;
		private inkWidgetReference _itemTab;
		private inkWidgetReference _femaleHovers;
		private inkWidgetReference _maleHovers;
		private inkWidgetReference _f_frontalCortexHoverTexture;
		private inkWidgetReference _f_eyesHoverTexture;
		private inkWidgetReference _f_cardiovascularHoverTexture;
		private inkWidgetReference _f_immuneHoverTexture;
		private inkWidgetReference _f_nervousHoverTexture;
		private inkWidgetReference _f_integumentaryHoverTexture;
		private inkWidgetReference _f_systemReplacementHoverTexture;
		private inkWidgetReference _f_musculoskeletalHoverTexture;
		private inkWidgetReference _f_handsHoverTexture;
		private inkWidgetReference _f_armsHoverTexture;
		private inkWidgetReference _f_legsHoverTexture;
		private inkWidgetReference _m_frontalCortexHoverTexture;
		private inkWidgetReference _m_eyesHoverTexture;
		private inkWidgetReference _m_cardiovascularHoverTexture;
		private inkWidgetReference _m_immuneHoverTexture;
		private inkWidgetReference _m_nervousHoverTexture;
		private inkWidgetReference _m_integumentaryHoverTexture;
		private inkWidgetReference _m_systemReplacementHoverTexture;
		private inkWidgetReference _m_musculoskeletalHoverTexture;
		private inkWidgetReference _m_handsHoverTexture;
		private inkWidgetReference _m_armsHoverTexture;
		private inkWidgetReference _m_legsHoverTexture;
		private inkWidgetReference _man_wiresTexture;
		private inkWidgetReference _woman_wiresTexture;
		private inkCompoundWidgetReference _frontalCortexAnchor;
		private inkCompoundWidgetReference _ocularCortexAnchor;
		private inkCompoundWidgetReference _leftMiddleGridAnchor;
		private inkCompoundWidgetReference _leftButtomGridAnchor;
		private inkCompoundWidgetReference _rightTopGridAnchor;
		private inkCompoundWidgetReference _rightButtomGridAnchor;
		private inkCompoundWidgetReference _skeletonAnchor;
		private inkCompoundWidgetReference _handsAnchor;
		private inkWidgetReference _ripperdocIdRoot;
		private inkTextWidgetReference _playerMoney;
		private inkWidgetReference _playerMoneyHolder;
		private inkCompoundWidgetReference _cyberwareSlotsList;
		private inkVirtualCompoundWidgetReference _cyberwareVirtualGrid;
		private inkWidgetReference _radioGroupRef;
		private inkCompoundWidgetReference _cyberwareInfoContainer;
		private inkWidgetReference _itemsListScrollAreaContainer;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _sortingDropdown;
		private CEnum<RipperdocModes> _mode;
		private CEnum<CyberwareScreenType> _screen;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<VendorDataManager> _vendorDataManager;
		private CEnum<gamedataEquipmentArea> _selectedArea;
		private CHandle<CyberwareInventoryMiniGrid> _equipmentGrid;
		private CHandle<gameIBlackboard> _vendorBlackboard;
		private CHandle<gameIBlackboard> _equipmentBlackboard;
		private CUInt32 _equipmentBlackboardCallback;
		private wCHandle<AGenericTooltipController> _cyberwareInfo;
		private CEnum<CyberwareInfoType> _cyberwareInfoType;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkVirtualGridController> _virtualCyberwareListController;
		private CHandle<CyberwareTemplateClassifier> _cyberwareClassifier;
		private CHandle<inkScriptableDataSourceWrapper> _cyberwareDataSource;
		private CHandle<CyberwareDataView> _cyberwaregDataView;
		private CEnum<RipperdocFilter> _currentFilter;
		private wCHandle<FilterRadioGroup> _radioGroup;
		private CHandle<RipperdocIdPanel> _ripperId;
		private CHandle<inkanimProxy> _hoverAnimation;
		private CHandle<inkanimProxy> _introDefaultAnimation;
		private CHandle<inkanimProxy> _outroDefaultAnimation;
		private CHandle<inkanimProxy> _introPaperdollAnimation;
		private CHandle<inkanimProxy> _outroPaperdollAnimation;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private CArray<CHandle<CyberwareInventoryMiniGrid>> _cyberareGrids;
		private CBool _isActivePanel;
		private CBool _equiped;
		private CInt32 _selectedPreviewSlot;

		[Ordinal(3)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
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

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("defaultTab")] 
		public inkWidgetReference DefaultTab
		{
			get
			{
				if (_defaultTab == null)
				{
					_defaultTab = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultTab", cr2w, this);
				}
				return _defaultTab;
			}
			set
			{
				if (_defaultTab == value)
				{
					return;
				}
				_defaultTab = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemTab")] 
		public inkWidgetReference ItemTab
		{
			get
			{
				if (_itemTab == null)
				{
					_itemTab = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemTab", cr2w, this);
				}
				return _itemTab;
			}
			set
			{
				if (_itemTab == value)
				{
					return;
				}
				_itemTab = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("femaleHovers")] 
		public inkWidgetReference FemaleHovers
		{
			get
			{
				if (_femaleHovers == null)
				{
					_femaleHovers = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "femaleHovers", cr2w, this);
				}
				return _femaleHovers;
			}
			set
			{
				if (_femaleHovers == value)
				{
					return;
				}
				_femaleHovers = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("maleHovers")] 
		public inkWidgetReference MaleHovers
		{
			get
			{
				if (_maleHovers == null)
				{
					_maleHovers = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "maleHovers", cr2w, this);
				}
				return _maleHovers;
			}
			set
			{
				if (_maleHovers == value)
				{
					return;
				}
				_maleHovers = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("F_frontalCortexHoverTexture")] 
		public inkWidgetReference F_frontalCortexHoverTexture
		{
			get
			{
				if (_f_frontalCortexHoverTexture == null)
				{
					_f_frontalCortexHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_frontalCortexHoverTexture", cr2w, this);
				}
				return _f_frontalCortexHoverTexture;
			}
			set
			{
				if (_f_frontalCortexHoverTexture == value)
				{
					return;
				}
				_f_frontalCortexHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("F_eyesHoverTexture")] 
		public inkWidgetReference F_eyesHoverTexture
		{
			get
			{
				if (_f_eyesHoverTexture == null)
				{
					_f_eyesHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_eyesHoverTexture", cr2w, this);
				}
				return _f_eyesHoverTexture;
			}
			set
			{
				if (_f_eyesHoverTexture == value)
				{
					return;
				}
				_f_eyesHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("F_cardiovascularHoverTexture")] 
		public inkWidgetReference F_cardiovascularHoverTexture
		{
			get
			{
				if (_f_cardiovascularHoverTexture == null)
				{
					_f_cardiovascularHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_cardiovascularHoverTexture", cr2w, this);
				}
				return _f_cardiovascularHoverTexture;
			}
			set
			{
				if (_f_cardiovascularHoverTexture == value)
				{
					return;
				}
				_f_cardiovascularHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("F_immuneHoverTexture")] 
		public inkWidgetReference F_immuneHoverTexture
		{
			get
			{
				if (_f_immuneHoverTexture == null)
				{
					_f_immuneHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_immuneHoverTexture", cr2w, this);
				}
				return _f_immuneHoverTexture;
			}
			set
			{
				if (_f_immuneHoverTexture == value)
				{
					return;
				}
				_f_immuneHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("F_nervousHoverTexture")] 
		public inkWidgetReference F_nervousHoverTexture
		{
			get
			{
				if (_f_nervousHoverTexture == null)
				{
					_f_nervousHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_nervousHoverTexture", cr2w, this);
				}
				return _f_nervousHoverTexture;
			}
			set
			{
				if (_f_nervousHoverTexture == value)
				{
					return;
				}
				_f_nervousHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("F_integumentaryHoverTexture")] 
		public inkWidgetReference F_integumentaryHoverTexture
		{
			get
			{
				if (_f_integumentaryHoverTexture == null)
				{
					_f_integumentaryHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_integumentaryHoverTexture", cr2w, this);
				}
				return _f_integumentaryHoverTexture;
			}
			set
			{
				if (_f_integumentaryHoverTexture == value)
				{
					return;
				}
				_f_integumentaryHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("F_systemReplacementHoverTexture")] 
		public inkWidgetReference F_systemReplacementHoverTexture
		{
			get
			{
				if (_f_systemReplacementHoverTexture == null)
				{
					_f_systemReplacementHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_systemReplacementHoverTexture", cr2w, this);
				}
				return _f_systemReplacementHoverTexture;
			}
			set
			{
				if (_f_systemReplacementHoverTexture == value)
				{
					return;
				}
				_f_systemReplacementHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("F_musculoskeletalHoverTexture")] 
		public inkWidgetReference F_musculoskeletalHoverTexture
		{
			get
			{
				if (_f_musculoskeletalHoverTexture == null)
				{
					_f_musculoskeletalHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_musculoskeletalHoverTexture", cr2w, this);
				}
				return _f_musculoskeletalHoverTexture;
			}
			set
			{
				if (_f_musculoskeletalHoverTexture == value)
				{
					return;
				}
				_f_musculoskeletalHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("F_handsHoverTexture")] 
		public inkWidgetReference F_handsHoverTexture
		{
			get
			{
				if (_f_handsHoverTexture == null)
				{
					_f_handsHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_handsHoverTexture", cr2w, this);
				}
				return _f_handsHoverTexture;
			}
			set
			{
				if (_f_handsHoverTexture == value)
				{
					return;
				}
				_f_handsHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("F_armsHoverTexture")] 
		public inkWidgetReference F_armsHoverTexture
		{
			get
			{
				if (_f_armsHoverTexture == null)
				{
					_f_armsHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_armsHoverTexture", cr2w, this);
				}
				return _f_armsHoverTexture;
			}
			set
			{
				if (_f_armsHoverTexture == value)
				{
					return;
				}
				_f_armsHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("F_legsHoverTexture")] 
		public inkWidgetReference F_legsHoverTexture
		{
			get
			{
				if (_f_legsHoverTexture == null)
				{
					_f_legsHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_legsHoverTexture", cr2w, this);
				}
				return _f_legsHoverTexture;
			}
			set
			{
				if (_f_legsHoverTexture == value)
				{
					return;
				}
				_f_legsHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("M_frontalCortexHoverTexture")] 
		public inkWidgetReference M_frontalCortexHoverTexture
		{
			get
			{
				if (_m_frontalCortexHoverTexture == null)
				{
					_m_frontalCortexHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_frontalCortexHoverTexture", cr2w, this);
				}
				return _m_frontalCortexHoverTexture;
			}
			set
			{
				if (_m_frontalCortexHoverTexture == value)
				{
					return;
				}
				_m_frontalCortexHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("M_eyesHoverTexture")] 
		public inkWidgetReference M_eyesHoverTexture
		{
			get
			{
				if (_m_eyesHoverTexture == null)
				{
					_m_eyesHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_eyesHoverTexture", cr2w, this);
				}
				return _m_eyesHoverTexture;
			}
			set
			{
				if (_m_eyesHoverTexture == value)
				{
					return;
				}
				_m_eyesHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("M_cardiovascularHoverTexture")] 
		public inkWidgetReference M_cardiovascularHoverTexture
		{
			get
			{
				if (_m_cardiovascularHoverTexture == null)
				{
					_m_cardiovascularHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_cardiovascularHoverTexture", cr2w, this);
				}
				return _m_cardiovascularHoverTexture;
			}
			set
			{
				if (_m_cardiovascularHoverTexture == value)
				{
					return;
				}
				_m_cardiovascularHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("M_immuneHoverTexture")] 
		public inkWidgetReference M_immuneHoverTexture
		{
			get
			{
				if (_m_immuneHoverTexture == null)
				{
					_m_immuneHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_immuneHoverTexture", cr2w, this);
				}
				return _m_immuneHoverTexture;
			}
			set
			{
				if (_m_immuneHoverTexture == value)
				{
					return;
				}
				_m_immuneHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("M_nervousHoverTexture")] 
		public inkWidgetReference M_nervousHoverTexture
		{
			get
			{
				if (_m_nervousHoverTexture == null)
				{
					_m_nervousHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_nervousHoverTexture", cr2w, this);
				}
				return _m_nervousHoverTexture;
			}
			set
			{
				if (_m_nervousHoverTexture == value)
				{
					return;
				}
				_m_nervousHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("M_integumentaryHoverTexture")] 
		public inkWidgetReference M_integumentaryHoverTexture
		{
			get
			{
				if (_m_integumentaryHoverTexture == null)
				{
					_m_integumentaryHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_integumentaryHoverTexture", cr2w, this);
				}
				return _m_integumentaryHoverTexture;
			}
			set
			{
				if (_m_integumentaryHoverTexture == value)
				{
					return;
				}
				_m_integumentaryHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("M_systemReplacementHoverTexture")] 
		public inkWidgetReference M_systemReplacementHoverTexture
		{
			get
			{
				if (_m_systemReplacementHoverTexture == null)
				{
					_m_systemReplacementHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_systemReplacementHoverTexture", cr2w, this);
				}
				return _m_systemReplacementHoverTexture;
			}
			set
			{
				if (_m_systemReplacementHoverTexture == value)
				{
					return;
				}
				_m_systemReplacementHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("M_musculoskeletalHoverTexture")] 
		public inkWidgetReference M_musculoskeletalHoverTexture
		{
			get
			{
				if (_m_musculoskeletalHoverTexture == null)
				{
					_m_musculoskeletalHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_musculoskeletalHoverTexture", cr2w, this);
				}
				return _m_musculoskeletalHoverTexture;
			}
			set
			{
				if (_m_musculoskeletalHoverTexture == value)
				{
					return;
				}
				_m_musculoskeletalHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("M_handsHoverTexture")] 
		public inkWidgetReference M_handsHoverTexture
		{
			get
			{
				if (_m_handsHoverTexture == null)
				{
					_m_handsHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_handsHoverTexture", cr2w, this);
				}
				return _m_handsHoverTexture;
			}
			set
			{
				if (_m_handsHoverTexture == value)
				{
					return;
				}
				_m_handsHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("M_armsHoverTexture")] 
		public inkWidgetReference M_armsHoverTexture
		{
			get
			{
				if (_m_armsHoverTexture == null)
				{
					_m_armsHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_armsHoverTexture", cr2w, this);
				}
				return _m_armsHoverTexture;
			}
			set
			{
				if (_m_armsHoverTexture == value)
				{
					return;
				}
				_m_armsHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("M_legsHoverTexture")] 
		public inkWidgetReference M_legsHoverTexture
		{
			get
			{
				if (_m_legsHoverTexture == null)
				{
					_m_legsHoverTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_legsHoverTexture", cr2w, this);
				}
				return _m_legsHoverTexture;
			}
			set
			{
				if (_m_legsHoverTexture == value)
				{
					return;
				}
				_m_legsHoverTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("man_wiresTexture")] 
		public inkWidgetReference Man_wiresTexture
		{
			get
			{
				if (_man_wiresTexture == null)
				{
					_man_wiresTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "man_wiresTexture", cr2w, this);
				}
				return _man_wiresTexture;
			}
			set
			{
				if (_man_wiresTexture == value)
				{
					return;
				}
				_man_wiresTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("woman_wiresTexture")] 
		public inkWidgetReference Woman_wiresTexture
		{
			get
			{
				if (_woman_wiresTexture == null)
				{
					_woman_wiresTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "woman_wiresTexture", cr2w, this);
				}
				return _woman_wiresTexture;
			}
			set
			{
				if (_woman_wiresTexture == value)
				{
					return;
				}
				_woman_wiresTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("frontalCortexAnchor")] 
		public inkCompoundWidgetReference FrontalCortexAnchor
		{
			get
			{
				if (_frontalCortexAnchor == null)
				{
					_frontalCortexAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "frontalCortexAnchor", cr2w, this);
				}
				return _frontalCortexAnchor;
			}
			set
			{
				if (_frontalCortexAnchor == value)
				{
					return;
				}
				_frontalCortexAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("ocularCortexAnchor")] 
		public inkCompoundWidgetReference OcularCortexAnchor
		{
			get
			{
				if (_ocularCortexAnchor == null)
				{
					_ocularCortexAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ocularCortexAnchor", cr2w, this);
				}
				return _ocularCortexAnchor;
			}
			set
			{
				if (_ocularCortexAnchor == value)
				{
					return;
				}
				_ocularCortexAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("leftMiddleGridAnchor")] 
		public inkCompoundWidgetReference LeftMiddleGridAnchor
		{
			get
			{
				if (_leftMiddleGridAnchor == null)
				{
					_leftMiddleGridAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "leftMiddleGridAnchor", cr2w, this);
				}
				return _leftMiddleGridAnchor;
			}
			set
			{
				if (_leftMiddleGridAnchor == value)
				{
					return;
				}
				_leftMiddleGridAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("leftButtomGridAnchor")] 
		public inkCompoundWidgetReference LeftButtomGridAnchor
		{
			get
			{
				if (_leftButtomGridAnchor == null)
				{
					_leftButtomGridAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "leftButtomGridAnchor", cr2w, this);
				}
				return _leftButtomGridAnchor;
			}
			set
			{
				if (_leftButtomGridAnchor == value)
				{
					return;
				}
				_leftButtomGridAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("rightTopGridAnchor")] 
		public inkCompoundWidgetReference RightTopGridAnchor
		{
			get
			{
				if (_rightTopGridAnchor == null)
				{
					_rightTopGridAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "rightTopGridAnchor", cr2w, this);
				}
				return _rightTopGridAnchor;
			}
			set
			{
				if (_rightTopGridAnchor == value)
				{
					return;
				}
				_rightTopGridAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("rightButtomGridAnchor")] 
		public inkCompoundWidgetReference RightButtomGridAnchor
		{
			get
			{
				if (_rightButtomGridAnchor == null)
				{
					_rightButtomGridAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "rightButtomGridAnchor", cr2w, this);
				}
				return _rightButtomGridAnchor;
			}
			set
			{
				if (_rightButtomGridAnchor == value)
				{
					return;
				}
				_rightButtomGridAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("skeletonAnchor")] 
		public inkCompoundWidgetReference SkeletonAnchor
		{
			get
			{
				if (_skeletonAnchor == null)
				{
					_skeletonAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "skeletonAnchor", cr2w, this);
				}
				return _skeletonAnchor;
			}
			set
			{
				if (_skeletonAnchor == value)
				{
					return;
				}
				_skeletonAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("handsAnchor")] 
		public inkCompoundWidgetReference HandsAnchor
		{
			get
			{
				if (_handsAnchor == null)
				{
					_handsAnchor = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "handsAnchor", cr2w, this);
				}
				return _handsAnchor;
			}
			set
			{
				if (_handsAnchor == value)
				{
					return;
				}
				_handsAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("ripperdocIdRoot")] 
		public inkWidgetReference RipperdocIdRoot
		{
			get
			{
				if (_ripperdocIdRoot == null)
				{
					_ripperdocIdRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ripperdocIdRoot", cr2w, this);
				}
				return _ripperdocIdRoot;
			}
			set
			{
				if (_ripperdocIdRoot == value)
				{
					return;
				}
				_ripperdocIdRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("playerMoney")] 
		public inkTextWidgetReference PlayerMoney
		{
			get
			{
				if (_playerMoney == null)
				{
					_playerMoney = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playerMoney", cr2w, this);
				}
				return _playerMoney;
			}
			set
			{
				if (_playerMoney == value)
				{
					return;
				}
				_playerMoney = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("playerMoneyHolder")] 
		public inkWidgetReference PlayerMoneyHolder
		{
			get
			{
				if (_playerMoneyHolder == null)
				{
					_playerMoneyHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerMoneyHolder", cr2w, this);
				}
				return _playerMoneyHolder;
			}
			set
			{
				if (_playerMoneyHolder == value)
				{
					return;
				}
				_playerMoneyHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("cyberwareSlotsList")] 
		public inkCompoundWidgetReference CyberwareSlotsList
		{
			get
			{
				if (_cyberwareSlotsList == null)
				{
					_cyberwareSlotsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "cyberwareSlotsList", cr2w, this);
				}
				return _cyberwareSlotsList;
			}
			set
			{
				if (_cyberwareSlotsList == value)
				{
					return;
				}
				_cyberwareSlotsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("cyberwareVirtualGrid")] 
		public inkVirtualCompoundWidgetReference CyberwareVirtualGrid
		{
			get
			{
				if (_cyberwareVirtualGrid == null)
				{
					_cyberwareVirtualGrid = (inkVirtualCompoundWidgetReference) CR2WTypeManager.Create("inkVirtualCompoundWidgetReference", "cyberwareVirtualGrid", cr2w, this);
				}
				return _cyberwareVirtualGrid;
			}
			set
			{
				if (_cyberwareVirtualGrid == value)
				{
					return;
				}
				_cyberwareVirtualGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("radioGroupRef")] 
		public inkWidgetReference RadioGroupRef
		{
			get
			{
				if (_radioGroupRef == null)
				{
					_radioGroupRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "radioGroupRef", cr2w, this);
				}
				return _radioGroupRef;
			}
			set
			{
				if (_radioGroupRef == value)
				{
					return;
				}
				_radioGroupRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("cyberwareInfoContainer")] 
		public inkCompoundWidgetReference CyberwareInfoContainer
		{
			get
			{
				if (_cyberwareInfoContainer == null)
				{
					_cyberwareInfoContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "cyberwareInfoContainer", cr2w, this);
				}
				return _cyberwareInfoContainer;
			}
			set
			{
				if (_cyberwareInfoContainer == value)
				{
					return;
				}
				_cyberwareInfoContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("itemsListScrollAreaContainer")] 
		public inkWidgetReference ItemsListScrollAreaContainer
		{
			get
			{
				if (_itemsListScrollAreaContainer == null)
				{
					_itemsListScrollAreaContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemsListScrollAreaContainer", cr2w, this);
				}
				return _itemsListScrollAreaContainer;
			}
			set
			{
				if (_itemsListScrollAreaContainer == value)
				{
					return;
				}
				_itemsListScrollAreaContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get
			{
				if (_sortingButton == null)
				{
					_sortingButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingButton", cr2w, this);
				}
				return _sortingButton;
			}
			set
			{
				if (_sortingButton == value)
				{
					return;
				}
				_sortingButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get
			{
				if (_sortingDropdown == null)
				{
					_sortingDropdown = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingDropdown", cr2w, this);
				}
				return _sortingDropdown;
			}
			set
			{
				if (_sortingDropdown == value)
				{
					return;
				}
				_sortingDropdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("mode")] 
		public CEnum<RipperdocModes> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<RipperdocModes>) CR2WTypeManager.Create("RipperdocModes", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("screen")] 
		public CEnum<CyberwareScreenType> Screen
		{
			get
			{
				if (_screen == null)
				{
					_screen = (CEnum<CyberwareScreenType>) CR2WTypeManager.Create("CyberwareScreenType", "screen", cr2w, this);
				}
				return _screen;
			}
			set
			{
				if (_screen == value)
				{
					return;
				}
				_screen = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
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

		[Ordinal(54)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
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

		[Ordinal(55)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get
			{
				if (_uiScriptableSystem == null)
				{
					_uiScriptableSystem = (wCHandle<UIScriptableSystem>) CR2WTypeManager.Create("whandle:UIScriptableSystem", "uiScriptableSystem", cr2w, this);
				}
				return _uiScriptableSystem;
			}
			set
			{
				if (_uiScriptableSystem == value)
				{
					return;
				}
				_uiScriptableSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get
			{
				if (_vendorUserData == null)
				{
					_vendorUserData = (CHandle<VendorUserData>) CR2WTypeManager.Create("handle:VendorUserData", "vendorUserData", cr2w, this);
				}
				return _vendorUserData;
			}
			set
			{
				if (_vendorUserData == value)
				{
					return;
				}
				_vendorUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get
			{
				if (_vendorDataManager == null)
				{
					_vendorDataManager = (CHandle<VendorDataManager>) CR2WTypeManager.Create("handle:VendorDataManager", "VendorDataManager", cr2w, this);
				}
				return _vendorDataManager;
			}
			set
			{
				if (_vendorDataManager == value)
				{
					return;
				}
				_vendorDataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("selectedArea")] 
		public CEnum<gamedataEquipmentArea> SelectedArea
		{
			get
			{
				if (_selectedArea == null)
				{
					_selectedArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "selectedArea", cr2w, this);
				}
				return _selectedArea;
			}
			set
			{
				if (_selectedArea == value)
				{
					return;
				}
				_selectedArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("equipmentGrid")] 
		public CHandle<CyberwareInventoryMiniGrid> EquipmentGrid
		{
			get
			{
				if (_equipmentGrid == null)
				{
					_equipmentGrid = (CHandle<CyberwareInventoryMiniGrid>) CR2WTypeManager.Create("handle:CyberwareInventoryMiniGrid", "equipmentGrid", cr2w, this);
				}
				return _equipmentGrid;
			}
			set
			{
				if (_equipmentGrid == value)
				{
					return;
				}
				_equipmentGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("VendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get
			{
				if (_vendorBlackboard == null)
				{
					_vendorBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "VendorBlackboard", cr2w, this);
				}
				return _vendorBlackboard;
			}
			set
			{
				if (_vendorBlackboard == value)
				{
					return;
				}
				_vendorBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("equipmentBlackboard")] 
		public CHandle<gameIBlackboard> EquipmentBlackboard
		{
			get
			{
				if (_equipmentBlackboard == null)
				{
					_equipmentBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "equipmentBlackboard", cr2w, this);
				}
				return _equipmentBlackboard;
			}
			set
			{
				if (_equipmentBlackboard == value)
				{
					return;
				}
				_equipmentBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("equipmentBlackboardCallback")] 
		public CUInt32 EquipmentBlackboardCallback
		{
			get
			{
				if (_equipmentBlackboardCallback == null)
				{
					_equipmentBlackboardCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "equipmentBlackboardCallback", cr2w, this);
				}
				return _equipmentBlackboardCallback;
			}
			set
			{
				if (_equipmentBlackboardCallback == value)
				{
					return;
				}
				_equipmentBlackboardCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("cyberwareInfo")] 
		public wCHandle<AGenericTooltipController> CyberwareInfo
		{
			get
			{
				if (_cyberwareInfo == null)
				{
					_cyberwareInfo = (wCHandle<AGenericTooltipController>) CR2WTypeManager.Create("whandle:AGenericTooltipController", "cyberwareInfo", cr2w, this);
				}
				return _cyberwareInfo;
			}
			set
			{
				if (_cyberwareInfo == value)
				{
					return;
				}
				_cyberwareInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("cyberwareInfoType")] 
		public CEnum<CyberwareInfoType> CyberwareInfoType
		{
			get
			{
				if (_cyberwareInfoType == null)
				{
					_cyberwareInfoType = (CEnum<CyberwareInfoType>) CR2WTypeManager.Create("CyberwareInfoType", "cyberwareInfoType", cr2w, this);
				}
				return _cyberwareInfoType;
			}
			set
			{
				if (_cyberwareInfoType == value)
				{
					return;
				}
				_cyberwareInfoType = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("virtualCyberwareListController")] 
		public CHandle<inkVirtualGridController> VirtualCyberwareListController
		{
			get
			{
				if (_virtualCyberwareListController == null)
				{
					_virtualCyberwareListController = (CHandle<inkVirtualGridController>) CR2WTypeManager.Create("handle:inkVirtualGridController", "virtualCyberwareListController", cr2w, this);
				}
				return _virtualCyberwareListController;
			}
			set
			{
				if (_virtualCyberwareListController == value)
				{
					return;
				}
				_virtualCyberwareListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("cyberwareClassifier")] 
		public CHandle<CyberwareTemplateClassifier> CyberwareClassifier
		{
			get
			{
				if (_cyberwareClassifier == null)
				{
					_cyberwareClassifier = (CHandle<CyberwareTemplateClassifier>) CR2WTypeManager.Create("handle:CyberwareTemplateClassifier", "cyberwareClassifier", cr2w, this);
				}
				return _cyberwareClassifier;
			}
			set
			{
				if (_cyberwareClassifier == value)
				{
					return;
				}
				_cyberwareClassifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("cyberwareDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> CyberwareDataSource
		{
			get
			{
				if (_cyberwareDataSource == null)
				{
					_cyberwareDataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "cyberwareDataSource", cr2w, this);
				}
				return _cyberwareDataSource;
			}
			set
			{
				if (_cyberwareDataSource == value)
				{
					return;
				}
				_cyberwareDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("cyberwaregDataView")] 
		public CHandle<CyberwareDataView> CyberwaregDataView
		{
			get
			{
				if (_cyberwaregDataView == null)
				{
					_cyberwaregDataView = (CHandle<CyberwareDataView>) CR2WTypeManager.Create("handle:CyberwareDataView", "cyberwaregDataView", cr2w, this);
				}
				return _cyberwaregDataView;
			}
			set
			{
				if (_cyberwaregDataView == value)
				{
					return;
				}
				_cyberwaregDataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("currentFilter")] 
		public CEnum<RipperdocFilter> CurrentFilter
		{
			get
			{
				if (_currentFilter == null)
				{
					_currentFilter = (CEnum<RipperdocFilter>) CR2WTypeManager.Create("RipperdocFilter", "currentFilter", cr2w, this);
				}
				return _currentFilter;
			}
			set
			{
				if (_currentFilter == value)
				{
					return;
				}
				_currentFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("radioGroup")] 
		public wCHandle<FilterRadioGroup> RadioGroup
		{
			get
			{
				if (_radioGroup == null)
				{
					_radioGroup = (wCHandle<FilterRadioGroup>) CR2WTypeManager.Create("whandle:FilterRadioGroup", "radioGroup", cr2w, this);
				}
				return _radioGroup;
			}
			set
			{
				if (_radioGroup == value)
				{
					return;
				}
				_radioGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("ripperId")] 
		public CHandle<RipperdocIdPanel> RipperId
		{
			get
			{
				if (_ripperId == null)
				{
					_ripperId = (CHandle<RipperdocIdPanel>) CR2WTypeManager.Create("handle:RipperdocIdPanel", "ripperId", cr2w, this);
				}
				return _ripperId;
			}
			set
			{
				if (_ripperId == value)
				{
					return;
				}
				_ripperId = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("hoverAnimation")] 
		public CHandle<inkanimProxy> HoverAnimation
		{
			get
			{
				if (_hoverAnimation == null)
				{
					_hoverAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hoverAnimation", cr2w, this);
				}
				return _hoverAnimation;
			}
			set
			{
				if (_hoverAnimation == value)
				{
					return;
				}
				_hoverAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("introDefaultAnimation")] 
		public CHandle<inkanimProxy> IntroDefaultAnimation
		{
			get
			{
				if (_introDefaultAnimation == null)
				{
					_introDefaultAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "introDefaultAnimation", cr2w, this);
				}
				return _introDefaultAnimation;
			}
			set
			{
				if (_introDefaultAnimation == value)
				{
					return;
				}
				_introDefaultAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("outroDefaultAnimation")] 
		public CHandle<inkanimProxy> OutroDefaultAnimation
		{
			get
			{
				if (_outroDefaultAnimation == null)
				{
					_outroDefaultAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "outroDefaultAnimation", cr2w, this);
				}
				return _outroDefaultAnimation;
			}
			set
			{
				if (_outroDefaultAnimation == value)
				{
					return;
				}
				_outroDefaultAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("introPaperdollAnimation")] 
		public CHandle<inkanimProxy> IntroPaperdollAnimation
		{
			get
			{
				if (_introPaperdollAnimation == null)
				{
					_introPaperdollAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "introPaperdollAnimation", cr2w, this);
				}
				return _introPaperdollAnimation;
			}
			set
			{
				if (_introPaperdollAnimation == value)
				{
					return;
				}
				_introPaperdollAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("outroPaperdollAnimation")] 
		public CHandle<inkanimProxy> OutroPaperdollAnimation
		{
			get
			{
				if (_outroPaperdollAnimation == null)
				{
					_outroPaperdollAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "outroPaperdollAnimation", cr2w, this);
				}
				return _outroPaperdollAnimation;
			}
			set
			{
				if (_outroPaperdollAnimation == value)
				{
					return;
				}
				_outroPaperdollAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get
			{
				if (_inventoryListener == null)
				{
					_inventoryListener = (CHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("handle:gameInventoryScriptListener", "inventoryListener", cr2w, this);
				}
				return _inventoryListener;
			}
			set
			{
				if (_inventoryListener == value)
				{
					return;
				}
				_inventoryListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("cyberareGrids")] 
		public CArray<CHandle<CyberwareInventoryMiniGrid>> CyberareGrids
		{
			get
			{
				if (_cyberareGrids == null)
				{
					_cyberareGrids = (CArray<CHandle<CyberwareInventoryMiniGrid>>) CR2WTypeManager.Create("array:handle:CyberwareInventoryMiniGrid", "cyberareGrids", cr2w, this);
				}
				return _cyberareGrids;
			}
			set
			{
				if (_cyberareGrids == value)
				{
					return;
				}
				_cyberareGrids = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("isActivePanel")] 
		public CBool IsActivePanel
		{
			get
			{
				if (_isActivePanel == null)
				{
					_isActivePanel = (CBool) CR2WTypeManager.Create("Bool", "isActivePanel", cr2w, this);
				}
				return _isActivePanel;
			}
			set
			{
				if (_isActivePanel == value)
				{
					return;
				}
				_isActivePanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("equiped")] 
		public CBool Equiped
		{
			get
			{
				if (_equiped == null)
				{
					_equiped = (CBool) CR2WTypeManager.Create("Bool", "equiped", cr2w, this);
				}
				return _equiped;
			}
			set
			{
				if (_equiped == value)
				{
					return;
				}
				_equiped = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("selectedPreviewSlot")] 
		public CInt32 SelectedPreviewSlot
		{
			get
			{
				if (_selectedPreviewSlot == null)
				{
					_selectedPreviewSlot = (CInt32) CR2WTypeManager.Create("Int32", "selectedPreviewSlot", cr2w, this);
				}
				return _selectedPreviewSlot;
			}
			set
			{
				if (_selectedPreviewSlot == value)
				{
					return;
				}
				_selectedPreviewSlot = value;
				PropertySet(this);
			}
		}

		public RipperDocGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
