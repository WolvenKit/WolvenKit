using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerInkGameController : DeviceInkGameControllerBase
	{
		private TweakDBID _layoutID;
		private CName _currentLayoutLibraryID;
		private wCHandle<inkWidget> _mainLayout;
		private CBool _devicesMenuInitialized;
		private CBool _devicesMenuSpawned;
		private CBool _devicesMenuSpawnRequested;
		private CBool _menuInitialized;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private CEnum<EDocumentType> _forceOpenDocumentType;
		private SDocumentAdress _forceOpenDocumentAdress;
		private CUInt32 _onMailThumbnailWidgetsUpdateListener;
		private CUInt32 _onFileThumbnailWidgetsUpdateListener;
		private CUInt32 _onMailWidgetsUpdateListener;
		private CUInt32 _onFileWidgetsUpdateListener;
		private CUInt32 _onMenuButtonWidgetsUpdateListener;
		private CUInt32 _onMainMenuButtonWidgetsUpdateListener;
		private CUInt32 _onBannerWidgetsUpdateListener;
		private CUInt32 _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("layoutID")] 
		public TweakDBID LayoutID
		{
			get
			{
				if (_layoutID == null)
				{
					_layoutID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "layoutID", cr2w, this);
				}
				return _layoutID;
			}
			set
			{
				if (_layoutID == value)
				{
					return;
				}
				_layoutID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("currentLayoutLibraryID")] 
		public CName CurrentLayoutLibraryID
		{
			get
			{
				if (_currentLayoutLibraryID == null)
				{
					_currentLayoutLibraryID = (CName) CR2WTypeManager.Create("CName", "currentLayoutLibraryID", cr2w, this);
				}
				return _currentLayoutLibraryID;
			}
			set
			{
				if (_currentLayoutLibraryID == value)
				{
					return;
				}
				_currentLayoutLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("mainLayout")] 
		public wCHandle<inkWidget> MainLayout
		{
			get
			{
				if (_mainLayout == null)
				{
					_mainLayout = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "mainLayout", cr2w, this);
				}
				return _mainLayout;
			}
			set
			{
				if (_mainLayout == value)
				{
					return;
				}
				_mainLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("devicesMenuInitialized")] 
		public CBool DevicesMenuInitialized
		{
			get
			{
				if (_devicesMenuInitialized == null)
				{
					_devicesMenuInitialized = (CBool) CR2WTypeManager.Create("Bool", "devicesMenuInitialized", cr2w, this);
				}
				return _devicesMenuInitialized;
			}
			set
			{
				if (_devicesMenuInitialized == value)
				{
					return;
				}
				_devicesMenuInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("devicesMenuSpawned")] 
		public CBool DevicesMenuSpawned
		{
			get
			{
				if (_devicesMenuSpawned == null)
				{
					_devicesMenuSpawned = (CBool) CR2WTypeManager.Create("Bool", "devicesMenuSpawned", cr2w, this);
				}
				return _devicesMenuSpawned;
			}
			set
			{
				if (_devicesMenuSpawned == value)
				{
					return;
				}
				_devicesMenuSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("devicesMenuSpawnRequested")] 
		public CBool DevicesMenuSpawnRequested
		{
			get
			{
				if (_devicesMenuSpawnRequested == null)
				{
					_devicesMenuSpawnRequested = (CBool) CR2WTypeManager.Create("Bool", "devicesMenuSpawnRequested", cr2w, this);
				}
				return _devicesMenuSpawnRequested;
			}
			set
			{
				if (_devicesMenuSpawnRequested == value)
				{
					return;
				}
				_devicesMenuSpawnRequested = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("menuInitialized")] 
		public CBool MenuInitialized
		{
			get
			{
				if (_menuInitialized == null)
				{
					_menuInitialized = (CBool) CR2WTypeManager.Create("Bool", "menuInitialized", cr2w, this);
				}
				return _menuInitialized;
			}
			set
			{
				if (_menuInitialized == value)
				{
					return;
				}
				_menuInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get
			{
				if (_mainDisplayWidget == null)
				{
					_mainDisplayWidget = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "mainDisplayWidget", cr2w, this);
				}
				return _mainDisplayWidget;
			}
			set
			{
				if (_mainDisplayWidget == value)
				{
					return;
				}
				_mainDisplayWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("forceOpenDocumentType")] 
		public CEnum<EDocumentType> ForceOpenDocumentType
		{
			get
			{
				if (_forceOpenDocumentType == null)
				{
					_forceOpenDocumentType = (CEnum<EDocumentType>) CR2WTypeManager.Create("EDocumentType", "forceOpenDocumentType", cr2w, this);
				}
				return _forceOpenDocumentType;
			}
			set
			{
				if (_forceOpenDocumentType == value)
				{
					return;
				}
				_forceOpenDocumentType = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("forceOpenDocumentAdress")] 
		public SDocumentAdress ForceOpenDocumentAdress
		{
			get
			{
				if (_forceOpenDocumentAdress == null)
				{
					_forceOpenDocumentAdress = (SDocumentAdress) CR2WTypeManager.Create("SDocumentAdress", "forceOpenDocumentAdress", cr2w, this);
				}
				return _forceOpenDocumentAdress;
			}
			set
			{
				if (_forceOpenDocumentAdress == value)
				{
					return;
				}
				_forceOpenDocumentAdress = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("onMailThumbnailWidgetsUpdateListener")] 
		public CUInt32 OnMailThumbnailWidgetsUpdateListener
		{
			get
			{
				if (_onMailThumbnailWidgetsUpdateListener == null)
				{
					_onMailThumbnailWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onMailThumbnailWidgetsUpdateListener", cr2w, this);
				}
				return _onMailThumbnailWidgetsUpdateListener;
			}
			set
			{
				if (_onMailThumbnailWidgetsUpdateListener == value)
				{
					return;
				}
				_onMailThumbnailWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("onFileThumbnailWidgetsUpdateListener")] 
		public CUInt32 OnFileThumbnailWidgetsUpdateListener
		{
			get
			{
				if (_onFileThumbnailWidgetsUpdateListener == null)
				{
					_onFileThumbnailWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onFileThumbnailWidgetsUpdateListener", cr2w, this);
				}
				return _onFileThumbnailWidgetsUpdateListener;
			}
			set
			{
				if (_onFileThumbnailWidgetsUpdateListener == value)
				{
					return;
				}
				_onFileThumbnailWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("onMailWidgetsUpdateListener")] 
		public CUInt32 OnMailWidgetsUpdateListener
		{
			get
			{
				if (_onMailWidgetsUpdateListener == null)
				{
					_onMailWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onMailWidgetsUpdateListener", cr2w, this);
				}
				return _onMailWidgetsUpdateListener;
			}
			set
			{
				if (_onMailWidgetsUpdateListener == value)
				{
					return;
				}
				_onMailWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("onFileWidgetsUpdateListener")] 
		public CUInt32 OnFileWidgetsUpdateListener
		{
			get
			{
				if (_onFileWidgetsUpdateListener == null)
				{
					_onFileWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onFileWidgetsUpdateListener", cr2w, this);
				}
				return _onFileWidgetsUpdateListener;
			}
			set
			{
				if (_onFileWidgetsUpdateListener == value)
				{
					return;
				}
				_onFileWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("onMenuButtonWidgetsUpdateListener")] 
		public CUInt32 OnMenuButtonWidgetsUpdateListener
		{
			get
			{
				if (_onMenuButtonWidgetsUpdateListener == null)
				{
					_onMenuButtonWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onMenuButtonWidgetsUpdateListener", cr2w, this);
				}
				return _onMenuButtonWidgetsUpdateListener;
			}
			set
			{
				if (_onMenuButtonWidgetsUpdateListener == value)
				{
					return;
				}
				_onMenuButtonWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("onMainMenuButtonWidgetsUpdateListener")] 
		public CUInt32 OnMainMenuButtonWidgetsUpdateListener
		{
			get
			{
				if (_onMainMenuButtonWidgetsUpdateListener == null)
				{
					_onMainMenuButtonWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onMainMenuButtonWidgetsUpdateListener", cr2w, this);
				}
				return _onMainMenuButtonWidgetsUpdateListener;
			}
			set
			{
				if (_onMainMenuButtonWidgetsUpdateListener == value)
				{
					return;
				}
				_onMainMenuButtonWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("onBannerWidgetsUpdateListener")] 
		public CUInt32 OnBannerWidgetsUpdateListener
		{
			get
			{
				if (_onBannerWidgetsUpdateListener == null)
				{
					_onBannerWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onBannerWidgetsUpdateListener", cr2w, this);
				}
				return _onBannerWidgetsUpdateListener;
			}
			set
			{
				if (_onBannerWidgetsUpdateListener == value)
				{
					return;
				}
				_onBannerWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get
			{
				if (_onGlitchingStateChangedListener == null)
				{
					_onGlitchingStateChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onGlitchingStateChangedListener", cr2w, this);
				}
				return _onGlitchingStateChangedListener;
			}
			set
			{
				if (_onGlitchingStateChangedListener == value)
				{
					return;
				}
				_onGlitchingStateChangedListener = value;
				PropertySet(this);
			}
		}

		public ComputerInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
