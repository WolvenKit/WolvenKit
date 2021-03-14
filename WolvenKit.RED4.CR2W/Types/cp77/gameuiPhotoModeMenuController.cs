using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeMenuController : gameuiWidgetGameController
	{
		private gameuiSetPhotoModeKeyEnabledCallback _setAttributeOptionEnabled;
		private gameuiSetPhotoModeKeyEnabledCallback _setCategoryEnabled;
		private inkWidgetReference _menuListRoot;
		private inkCompoundWidgetReference _radioButtons;
		private CName _listContainerId;
		private inkWidgetReference _menuArea;
		private inkWidgetReference _inputCameraKbd;
		private inkWidgetReference _inputCameraPad;
		private inkWidgetReference _inputStickersKbd;
		private inkWidgetReference _inputStickersPad;
		private inkWidgetReference _inputSaveLoadKbd;
		private inkWidgetReference _inputSaveLoadPad;
		private inkWidgetReference _inputExit;
		private inkWidgetReference _inputScreenshot;
		private inkWidgetReference _cameraLocation;
		private inkHorizontalPanelWidgetReference _inputBottomRoot;
		private CName _ps4InputLibraryId;
		private CName _xboxInputLibraryId;
		private wCHandle<inkWidget> _ps4InputWidget;
		private wCHandle<inkWidget> _xboxInputWidget;
		private CArray<wCHandle<inkWidget>> _menuPages;
		private wCHandle<PhotoModeTopBarController> _topButtonsController;
		private wCHandle<PhotoModeCameraLocation> _cameraLocationController;
		private CUInt32 _currentPage;
		private CBool _isHoverOver;
		private CBool _holdSafeguard;
		private CHandle<inkGameNotificationData> _notificationUserData;
		private CHandle<inkGameNotificationToken> _notificationToken;
		private CHandle<inkanimProxy> _loopAnimproxy;

		[Ordinal(2)] 
		[RED("SetAttributeOptionEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetAttributeOptionEnabled
		{
			get
			{
				if (_setAttributeOptionEnabled == null)
				{
					_setAttributeOptionEnabled = (gameuiSetPhotoModeKeyEnabledCallback) CR2WTypeManager.Create("gameuiSetPhotoModeKeyEnabledCallback", "SetAttributeOptionEnabled", cr2w, this);
				}
				return _setAttributeOptionEnabled;
			}
			set
			{
				if (_setAttributeOptionEnabled == value)
				{
					return;
				}
				_setAttributeOptionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("SetCategoryEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetCategoryEnabled
		{
			get
			{
				if (_setCategoryEnabled == null)
				{
					_setCategoryEnabled = (gameuiSetPhotoModeKeyEnabledCallback) CR2WTypeManager.Create("gameuiSetPhotoModeKeyEnabledCallback", "SetCategoryEnabled", cr2w, this);
				}
				return _setCategoryEnabled;
			}
			set
			{
				if (_setCategoryEnabled == value)
				{
					return;
				}
				_setCategoryEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("menuListRoot")] 
		public inkWidgetReference MenuListRoot
		{
			get
			{
				if (_menuListRoot == null)
				{
					_menuListRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuListRoot", cr2w, this);
				}
				return _menuListRoot;
			}
			set
			{
				if (_menuListRoot == value)
				{
					return;
				}
				_menuListRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("radioButtons")] 
		public inkCompoundWidgetReference RadioButtons
		{
			get
			{
				if (_radioButtons == null)
				{
					_radioButtons = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "radioButtons", cr2w, this);
				}
				return _radioButtons;
			}
			set
			{
				if (_radioButtons == value)
				{
					return;
				}
				_radioButtons = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("listContainerId")] 
		public CName ListContainerId
		{
			get
			{
				if (_listContainerId == null)
				{
					_listContainerId = (CName) CR2WTypeManager.Create("CName", "listContainerId", cr2w, this);
				}
				return _listContainerId;
			}
			set
			{
				if (_listContainerId == value)
				{
					return;
				}
				_listContainerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("menuArea")] 
		public inkWidgetReference MenuArea
		{
			get
			{
				if (_menuArea == null)
				{
					_menuArea = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuArea", cr2w, this);
				}
				return _menuArea;
			}
			set
			{
				if (_menuArea == value)
				{
					return;
				}
				_menuArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inputCameraKbd")] 
		public inkWidgetReference InputCameraKbd
		{
			get
			{
				if (_inputCameraKbd == null)
				{
					_inputCameraKbd = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputCameraKbd", cr2w, this);
				}
				return _inputCameraKbd;
			}
			set
			{
				if (_inputCameraKbd == value)
				{
					return;
				}
				_inputCameraKbd = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("inputCameraPad")] 
		public inkWidgetReference InputCameraPad
		{
			get
			{
				if (_inputCameraPad == null)
				{
					_inputCameraPad = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputCameraPad", cr2w, this);
				}
				return _inputCameraPad;
			}
			set
			{
				if (_inputCameraPad == value)
				{
					return;
				}
				_inputCameraPad = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("inputStickersKbd")] 
		public inkWidgetReference InputStickersKbd
		{
			get
			{
				if (_inputStickersKbd == null)
				{
					_inputStickersKbd = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputStickersKbd", cr2w, this);
				}
				return _inputStickersKbd;
			}
			set
			{
				if (_inputStickersKbd == value)
				{
					return;
				}
				_inputStickersKbd = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inputStickersPad")] 
		public inkWidgetReference InputStickersPad
		{
			get
			{
				if (_inputStickersPad == null)
				{
					_inputStickersPad = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputStickersPad", cr2w, this);
				}
				return _inputStickersPad;
			}
			set
			{
				if (_inputStickersPad == value)
				{
					return;
				}
				_inputStickersPad = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inputSaveLoadKbd")] 
		public inkWidgetReference InputSaveLoadKbd
		{
			get
			{
				if (_inputSaveLoadKbd == null)
				{
					_inputSaveLoadKbd = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputSaveLoadKbd", cr2w, this);
				}
				return _inputSaveLoadKbd;
			}
			set
			{
				if (_inputSaveLoadKbd == value)
				{
					return;
				}
				_inputSaveLoadKbd = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inputSaveLoadPad")] 
		public inkWidgetReference InputSaveLoadPad
		{
			get
			{
				if (_inputSaveLoadPad == null)
				{
					_inputSaveLoadPad = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputSaveLoadPad", cr2w, this);
				}
				return _inputSaveLoadPad;
			}
			set
			{
				if (_inputSaveLoadPad == value)
				{
					return;
				}
				_inputSaveLoadPad = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("inputExit")] 
		public inkWidgetReference InputExit
		{
			get
			{
				if (_inputExit == null)
				{
					_inputExit = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputExit", cr2w, this);
				}
				return _inputExit;
			}
			set
			{
				if (_inputExit == value)
				{
					return;
				}
				_inputExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("inputScreenshot")] 
		public inkWidgetReference InputScreenshot
		{
			get
			{
				if (_inputScreenshot == null)
				{
					_inputScreenshot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputScreenshot", cr2w, this);
				}
				return _inputScreenshot;
			}
			set
			{
				if (_inputScreenshot == value)
				{
					return;
				}
				_inputScreenshot = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cameraLocation")] 
		public inkWidgetReference CameraLocation
		{
			get
			{
				if (_cameraLocation == null)
				{
					_cameraLocation = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cameraLocation", cr2w, this);
				}
				return _cameraLocation;
			}
			set
			{
				if (_cameraLocation == value)
				{
					return;
				}
				_cameraLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("inputBottomRoot")] 
		public inkHorizontalPanelWidgetReference InputBottomRoot
		{
			get
			{
				if (_inputBottomRoot == null)
				{
					_inputBottomRoot = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "inputBottomRoot", cr2w, this);
				}
				return _inputBottomRoot;
			}
			set
			{
				if (_inputBottomRoot == value)
				{
					return;
				}
				_inputBottomRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ps4InputLibraryId")] 
		public CName Ps4InputLibraryId
		{
			get
			{
				if (_ps4InputLibraryId == null)
				{
					_ps4InputLibraryId = (CName) CR2WTypeManager.Create("CName", "ps4InputLibraryId", cr2w, this);
				}
				return _ps4InputLibraryId;
			}
			set
			{
				if (_ps4InputLibraryId == value)
				{
					return;
				}
				_ps4InputLibraryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("xboxInputLibraryId")] 
		public CName XboxInputLibraryId
		{
			get
			{
				if (_xboxInputLibraryId == null)
				{
					_xboxInputLibraryId = (CName) CR2WTypeManager.Create("CName", "xboxInputLibraryId", cr2w, this);
				}
				return _xboxInputLibraryId;
			}
			set
			{
				if (_xboxInputLibraryId == value)
				{
					return;
				}
				_xboxInputLibraryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("ps4InputWidget")] 
		public wCHandle<inkWidget> Ps4InputWidget
		{
			get
			{
				if (_ps4InputWidget == null)
				{
					_ps4InputWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "ps4InputWidget", cr2w, this);
				}
				return _ps4InputWidget;
			}
			set
			{
				if (_ps4InputWidget == value)
				{
					return;
				}
				_ps4InputWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("xboxInputWidget")] 
		public wCHandle<inkWidget> XboxInputWidget
		{
			get
			{
				if (_xboxInputWidget == null)
				{
					_xboxInputWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "xboxInputWidget", cr2w, this);
				}
				return _xboxInputWidget;
			}
			set
			{
				if (_xboxInputWidget == value)
				{
					return;
				}
				_xboxInputWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("menuPages")] 
		public CArray<wCHandle<inkWidget>> MenuPages
		{
			get
			{
				if (_menuPages == null)
				{
					_menuPages = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "menuPages", cr2w, this);
				}
				return _menuPages;
			}
			set
			{
				if (_menuPages == value)
				{
					return;
				}
				_menuPages = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("topButtonsController")] 
		public wCHandle<PhotoModeTopBarController> TopButtonsController
		{
			get
			{
				if (_topButtonsController == null)
				{
					_topButtonsController = (wCHandle<PhotoModeTopBarController>) CR2WTypeManager.Create("whandle:PhotoModeTopBarController", "topButtonsController", cr2w, this);
				}
				return _topButtonsController;
			}
			set
			{
				if (_topButtonsController == value)
				{
					return;
				}
				_topButtonsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("cameraLocationController")] 
		public wCHandle<PhotoModeCameraLocation> CameraLocationController
		{
			get
			{
				if (_cameraLocationController == null)
				{
					_cameraLocationController = (wCHandle<PhotoModeCameraLocation>) CR2WTypeManager.Create("whandle:PhotoModeCameraLocation", "cameraLocationController", cr2w, this);
				}
				return _cameraLocationController;
			}
			set
			{
				if (_cameraLocationController == value)
				{
					return;
				}
				_cameraLocationController = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("currentPage")] 
		public CUInt32 CurrentPage
		{
			get
			{
				if (_currentPage == null)
				{
					_currentPage = (CUInt32) CR2WTypeManager.Create("Uint32", "currentPage", cr2w, this);
				}
				return _currentPage;
			}
			set
			{
				if (_currentPage == value)
				{
					return;
				}
				_currentPage = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("IsHoverOver")] 
		public CBool IsHoverOver
		{
			get
			{
				if (_isHoverOver == null)
				{
					_isHoverOver = (CBool) CR2WTypeManager.Create("Bool", "IsHoverOver", cr2w, this);
				}
				return _isHoverOver;
			}
			set
			{
				if (_isHoverOver == value)
				{
					return;
				}
				_isHoverOver = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("holdSafeguard")] 
		public CBool HoldSafeguard
		{
			get
			{
				if (_holdSafeguard == null)
				{
					_holdSafeguard = (CBool) CR2WTypeManager.Create("Bool", "holdSafeguard", cr2w, this);
				}
				return _holdSafeguard;
			}
			set
			{
				if (_holdSafeguard == value)
				{
					return;
				}
				_holdSafeguard = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("notificationUserData")] 
		public CHandle<inkGameNotificationData> NotificationUserData
		{
			get
			{
				if (_notificationUserData == null)
				{
					_notificationUserData = (CHandle<inkGameNotificationData>) CR2WTypeManager.Create("handle:inkGameNotificationData", "notificationUserData", cr2w, this);
				}
				return _notificationUserData;
			}
			set
			{
				if (_notificationUserData == value)
				{
					return;
				}
				_notificationUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("notificationToken")] 
		public CHandle<inkGameNotificationToken> NotificationToken
		{
			get
			{
				if (_notificationToken == null)
				{
					_notificationToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "notificationToken", cr2w, this);
				}
				return _notificationToken;
			}
			set
			{
				if (_notificationToken == value)
				{
					return;
				}
				_notificationToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("loopAnimproxy")] 
		public CHandle<inkanimProxy> LoopAnimproxy
		{
			get
			{
				if (_loopAnimproxy == null)
				{
					_loopAnimproxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "loopAnimproxy", cr2w, this);
				}
				return _loopAnimproxy;
			}
			set
			{
				if (_loopAnimproxy == value)
				{
					return;
				}
				_loopAnimproxy = value;
				PropertySet(this);
			}
		}

		public gameuiPhotoModeMenuController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
