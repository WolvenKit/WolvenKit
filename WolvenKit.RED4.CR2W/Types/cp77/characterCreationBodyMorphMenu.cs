using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphMenu : gameuiBaseCharacterCreationController
	{
		private CName _defaultPreviewSlot;
		private inkCompoundWidgetReference _optionsList;
		private inkWidgetReference _colorPicker;
		private inkWidgetReference _colorPickerBG;
		private inkWidgetReference _colorPickerClose;
		private inkScrollAreaWidgetReference _scrollArea;
		private CHandle<inkCompoundWidget> _optionList;
		private inkWidgetReference _previousPageBtn;
		private inkImageWidgetReference _previousPageBtnBg;
		private inkImageWidgetReference _nextPageBtnBg;
		private inkWidgetReference _backConfirmation;
		private inkWidgetReference _backConfirmationWidget;
		private inkWidgetReference _confirmationConfirmBtn;
		private inkWidgetReference _confirmationCloseBtn;
		private inkWidgetReference _preset1;
		private inkWidgetReference _preset2;
		private inkWidgetReference _preset3;
		private inkWidgetReference _randomize;
		private inkImageWidgetReference _preset1Thumbnail;
		private inkImageWidgetReference _preset2Thumbnail;
		private inkImageWidgetReference _preset3Thumbnail;
		private inkImageWidgetReference _randomizThumbnail;
		private inkImageWidgetReference _preset1Bg;
		private inkImageWidgetReference _preset2Bg;
		private inkImageWidgetReference _preset3Bg;
		private inkImageWidgetReference _randomizBg;
		private inkWidgetReference _navigationButtons;
		private CBool _hideColorPickerNextFrame;
		private wCHandle<inkWidget> _colorPickerOwner;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _confirmAnimationProxy;
		private CHandle<inkanimProxy> _optionListAnimationProxy;
		private CBool _optionsListInitialized;
		private CBool _introPlayed;
		private wCHandle<inkListController> _menuListController;
		private wCHandle<inkWidget> _cachedCursor;

		[Ordinal(6)] 
		[RED("defaultPreviewSlot")] 
		public CName DefaultPreviewSlot
		{
			get
			{
				if (_defaultPreviewSlot == null)
				{
					_defaultPreviewSlot = (CName) CR2WTypeManager.Create("CName", "defaultPreviewSlot", cr2w, this);
				}
				return _defaultPreviewSlot;
			}
			set
			{
				if (_defaultPreviewSlot == value)
				{
					return;
				}
				_defaultPreviewSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("optionsList")] 
		public inkCompoundWidgetReference OptionsList
		{
			get
			{
				if (_optionsList == null)
				{
					_optionsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "optionsList", cr2w, this);
				}
				return _optionsList;
			}
			set
			{
				if (_optionsList == value)
				{
					return;
				}
				_optionsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("colorPicker")] 
		public inkWidgetReference ColorPicker
		{
			get
			{
				if (_colorPicker == null)
				{
					_colorPicker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "colorPicker", cr2w, this);
				}
				return _colorPicker;
			}
			set
			{
				if (_colorPicker == value)
				{
					return;
				}
				_colorPicker = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("colorPickerBG")] 
		public inkWidgetReference ColorPickerBG
		{
			get
			{
				if (_colorPickerBG == null)
				{
					_colorPickerBG = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "colorPickerBG", cr2w, this);
				}
				return _colorPickerBG;
			}
			set
			{
				if (_colorPickerBG == value)
				{
					return;
				}
				_colorPickerBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("colorPickerClose")] 
		public inkWidgetReference ColorPickerClose
		{
			get
			{
				if (_colorPickerClose == null)
				{
					_colorPickerClose = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "colorPickerClose", cr2w, this);
				}
				return _colorPickerClose;
			}
			set
			{
				if (_colorPickerClose == value)
				{
					return;
				}
				_colorPickerClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get
			{
				if (_scrollArea == null)
				{
					_scrollArea = (inkScrollAreaWidgetReference) CR2WTypeManager.Create("inkScrollAreaWidgetReference", "scrollArea", cr2w, this);
				}
				return _scrollArea;
			}
			set
			{
				if (_scrollArea == value)
				{
					return;
				}
				_scrollArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("optionList")] 
		public CHandle<inkCompoundWidget> OptionList
		{
			get
			{
				if (_optionList == null)
				{
					_optionList = (CHandle<inkCompoundWidget>) CR2WTypeManager.Create("handle:inkCompoundWidget", "optionList", cr2w, this);
				}
				return _optionList;
			}
			set
			{
				if (_optionList == value)
				{
					return;
				}
				_optionList = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get
			{
				if (_previousPageBtn == null)
				{
					_previousPageBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "previousPageBtn", cr2w, this);
				}
				return _previousPageBtn;
			}
			set
			{
				if (_previousPageBtn == value)
				{
					return;
				}
				_previousPageBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("previousPageBtnBg")] 
		public inkImageWidgetReference PreviousPageBtnBg
		{
			get
			{
				if (_previousPageBtnBg == null)
				{
					_previousPageBtnBg = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "previousPageBtnBg", cr2w, this);
				}
				return _previousPageBtnBg;
			}
			set
			{
				if (_previousPageBtnBg == value)
				{
					return;
				}
				_previousPageBtnBg = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("nextPageBtnBg")] 
		public inkImageWidgetReference NextPageBtnBg
		{
			get
			{
				if (_nextPageBtnBg == null)
				{
					_nextPageBtnBg = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "nextPageBtnBg", cr2w, this);
				}
				return _nextPageBtnBg;
			}
			set
			{
				if (_nextPageBtnBg == value)
				{
					return;
				}
				_nextPageBtnBg = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("backConfirmation")] 
		public inkWidgetReference BackConfirmation
		{
			get
			{
				if (_backConfirmation == null)
				{
					_backConfirmation = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backConfirmation", cr2w, this);
				}
				return _backConfirmation;
			}
			set
			{
				if (_backConfirmation == value)
				{
					return;
				}
				_backConfirmation = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("backConfirmationWidget")] 
		public inkWidgetReference BackConfirmationWidget
		{
			get
			{
				if (_backConfirmationWidget == null)
				{
					_backConfirmationWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backConfirmationWidget", cr2w, this);
				}
				return _backConfirmationWidget;
			}
			set
			{
				if (_backConfirmationWidget == value)
				{
					return;
				}
				_backConfirmationWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get
			{
				if (_confirmationConfirmBtn == null)
				{
					_confirmationConfirmBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ConfirmationConfirmBtn", cr2w, this);
				}
				return _confirmationConfirmBtn;
			}
			set
			{
				if (_confirmationConfirmBtn == value)
				{
					return;
				}
				_confirmationConfirmBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get
			{
				if (_confirmationCloseBtn == null)
				{
					_confirmationCloseBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ConfirmationCloseBtn", cr2w, this);
				}
				return _confirmationCloseBtn;
			}
			set
			{
				if (_confirmationCloseBtn == value)
				{
					return;
				}
				_confirmationCloseBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("preset1")] 
		public inkWidgetReference Preset1
		{
			get
			{
				if (_preset1 == null)
				{
					_preset1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "preset1", cr2w, this);
				}
				return _preset1;
			}
			set
			{
				if (_preset1 == value)
				{
					return;
				}
				_preset1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("preset2")] 
		public inkWidgetReference Preset2
		{
			get
			{
				if (_preset2 == null)
				{
					_preset2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "preset2", cr2w, this);
				}
				return _preset2;
			}
			set
			{
				if (_preset2 == value)
				{
					return;
				}
				_preset2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("preset3")] 
		public inkWidgetReference Preset3
		{
			get
			{
				if (_preset3 == null)
				{
					_preset3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "preset3", cr2w, this);
				}
				return _preset3;
			}
			set
			{
				if (_preset3 == value)
				{
					return;
				}
				_preset3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("randomize")] 
		public inkWidgetReference Randomize
		{
			get
			{
				if (_randomize == null)
				{
					_randomize = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "randomize", cr2w, this);
				}
				return _randomize;
			}
			set
			{
				if (_randomize == value)
				{
					return;
				}
				_randomize = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("preset1Thumbnail")] 
		public inkImageWidgetReference Preset1Thumbnail
		{
			get
			{
				if (_preset1Thumbnail == null)
				{
					_preset1Thumbnail = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "preset1Thumbnail", cr2w, this);
				}
				return _preset1Thumbnail;
			}
			set
			{
				if (_preset1Thumbnail == value)
				{
					return;
				}
				_preset1Thumbnail = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("preset2Thumbnail")] 
		public inkImageWidgetReference Preset2Thumbnail
		{
			get
			{
				if (_preset2Thumbnail == null)
				{
					_preset2Thumbnail = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "preset2Thumbnail", cr2w, this);
				}
				return _preset2Thumbnail;
			}
			set
			{
				if (_preset2Thumbnail == value)
				{
					return;
				}
				_preset2Thumbnail = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("preset3Thumbnail")] 
		public inkImageWidgetReference Preset3Thumbnail
		{
			get
			{
				if (_preset3Thumbnail == null)
				{
					_preset3Thumbnail = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "preset3Thumbnail", cr2w, this);
				}
				return _preset3Thumbnail;
			}
			set
			{
				if (_preset3Thumbnail == value)
				{
					return;
				}
				_preset3Thumbnail = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("randomizThumbnail")] 
		public inkImageWidgetReference RandomizThumbnail
		{
			get
			{
				if (_randomizThumbnail == null)
				{
					_randomizThumbnail = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "randomizThumbnail", cr2w, this);
				}
				return _randomizThumbnail;
			}
			set
			{
				if (_randomizThumbnail == value)
				{
					return;
				}
				_randomizThumbnail = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("preset1Bg")] 
		public inkImageWidgetReference Preset1Bg
		{
			get
			{
				if (_preset1Bg == null)
				{
					_preset1Bg = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "preset1Bg", cr2w, this);
				}
				return _preset1Bg;
			}
			set
			{
				if (_preset1Bg == value)
				{
					return;
				}
				_preset1Bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("preset2Bg")] 
		public inkImageWidgetReference Preset2Bg
		{
			get
			{
				if (_preset2Bg == null)
				{
					_preset2Bg = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "preset2Bg", cr2w, this);
				}
				return _preset2Bg;
			}
			set
			{
				if (_preset2Bg == value)
				{
					return;
				}
				_preset2Bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("preset3Bg")] 
		public inkImageWidgetReference Preset3Bg
		{
			get
			{
				if (_preset3Bg == null)
				{
					_preset3Bg = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "preset3Bg", cr2w, this);
				}
				return _preset3Bg;
			}
			set
			{
				if (_preset3Bg == value)
				{
					return;
				}
				_preset3Bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("randomizBg")] 
		public inkImageWidgetReference RandomizBg
		{
			get
			{
				if (_randomizBg == null)
				{
					_randomizBg = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "randomizBg", cr2w, this);
				}
				return _randomizBg;
			}
			set
			{
				if (_randomizBg == value)
				{
					return;
				}
				_randomizBg = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get
			{
				if (_navigationButtons == null)
				{
					_navigationButtons = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "navigationButtons", cr2w, this);
				}
				return _navigationButtons;
			}
			set
			{
				if (_navigationButtons == value)
				{
					return;
				}
				_navigationButtons = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("hideColorPickerNextFrame")] 
		public CBool HideColorPickerNextFrame
		{
			get
			{
				if (_hideColorPickerNextFrame == null)
				{
					_hideColorPickerNextFrame = (CBool) CR2WTypeManager.Create("Bool", "hideColorPickerNextFrame", cr2w, this);
				}
				return _hideColorPickerNextFrame;
			}
			set
			{
				if (_hideColorPickerNextFrame == value)
				{
					return;
				}
				_hideColorPickerNextFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("colorPickerOwner")] 
		public wCHandle<inkWidget> ColorPickerOwner
		{
			get
			{
				if (_colorPickerOwner == null)
				{
					_colorPickerOwner = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "colorPickerOwner", cr2w, this);
				}
				return _colorPickerOwner;
			}
			set
			{
				if (_colorPickerOwner == value)
				{
					return;
				}
				_colorPickerOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
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

		[Ordinal(36)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get
			{
				if (_confirmAnimationProxy == null)
				{
					_confirmAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "confirmAnimationProxy", cr2w, this);
				}
				return _confirmAnimationProxy;
			}
			set
			{
				if (_confirmAnimationProxy == value)
				{
					return;
				}
				_confirmAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("optionListAnimationProxy")] 
		public CHandle<inkanimProxy> OptionListAnimationProxy
		{
			get
			{
				if (_optionListAnimationProxy == null)
				{
					_optionListAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "optionListAnimationProxy", cr2w, this);
				}
				return _optionListAnimationProxy;
			}
			set
			{
				if (_optionListAnimationProxy == value)
				{
					return;
				}
				_optionListAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get
			{
				if (_optionsListInitialized == null)
				{
					_optionsListInitialized = (CBool) CR2WTypeManager.Create("Bool", "optionsListInitialized", cr2w, this);
				}
				return _optionsListInitialized;
			}
			set
			{
				if (_optionsListInitialized == value)
				{
					return;
				}
				_optionsListInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("introPlayed")] 
		public CBool IntroPlayed
		{
			get
			{
				if (_introPlayed == null)
				{
					_introPlayed = (CBool) CR2WTypeManager.Create("Bool", "introPlayed", cr2w, this);
				}
				return _introPlayed;
			}
			set
			{
				if (_introPlayed == value)
				{
					return;
				}
				_introPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("menuListController")] 
		public wCHandle<inkListController> MenuListController
		{
			get
			{
				if (_menuListController == null)
				{
					_menuListController = (wCHandle<inkListController>) CR2WTypeManager.Create("whandle:inkListController", "menuListController", cr2w, this);
				}
				return _menuListController;
			}
			set
			{
				if (_menuListController == value)
				{
					return;
				}
				_menuListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("cachedCursor")] 
		public wCHandle<inkWidget> CachedCursor
		{
			get
			{
				if (_cachedCursor == null)
				{
					_cachedCursor = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "cachedCursor", cr2w, this);
				}
				return _cachedCursor;
			}
			set
			{
				if (_cachedCursor == value)
				{
					return;
				}
				_cachedCursor = value;
				PropertySet(this);
			}
		}

		public characterCreationBodyMorphMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
