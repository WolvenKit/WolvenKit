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
			get => GetProperty(ref _layoutID);
			set => SetProperty(ref _layoutID, value);
		}

		[Ordinal(17)] 
		[RED("currentLayoutLibraryID")] 
		public CName CurrentLayoutLibraryID
		{
			get => GetProperty(ref _currentLayoutLibraryID);
			set => SetProperty(ref _currentLayoutLibraryID, value);
		}

		[Ordinal(18)] 
		[RED("mainLayout")] 
		public wCHandle<inkWidget> MainLayout
		{
			get => GetProperty(ref _mainLayout);
			set => SetProperty(ref _mainLayout, value);
		}

		[Ordinal(19)] 
		[RED("devicesMenuInitialized")] 
		public CBool DevicesMenuInitialized
		{
			get => GetProperty(ref _devicesMenuInitialized);
			set => SetProperty(ref _devicesMenuInitialized, value);
		}

		[Ordinal(20)] 
		[RED("devicesMenuSpawned")] 
		public CBool DevicesMenuSpawned
		{
			get => GetProperty(ref _devicesMenuSpawned);
			set => SetProperty(ref _devicesMenuSpawned, value);
		}

		[Ordinal(21)] 
		[RED("devicesMenuSpawnRequested")] 
		public CBool DevicesMenuSpawnRequested
		{
			get => GetProperty(ref _devicesMenuSpawnRequested);
			set => SetProperty(ref _devicesMenuSpawnRequested, value);
		}

		[Ordinal(22)] 
		[RED("menuInitialized")] 
		public CBool MenuInitialized
		{
			get => GetProperty(ref _menuInitialized);
			set => SetProperty(ref _menuInitialized, value);
		}

		[Ordinal(23)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(24)] 
		[RED("forceOpenDocumentType")] 
		public CEnum<EDocumentType> ForceOpenDocumentType
		{
			get => GetProperty(ref _forceOpenDocumentType);
			set => SetProperty(ref _forceOpenDocumentType, value);
		}

		[Ordinal(25)] 
		[RED("forceOpenDocumentAdress")] 
		public SDocumentAdress ForceOpenDocumentAdress
		{
			get => GetProperty(ref _forceOpenDocumentAdress);
			set => SetProperty(ref _forceOpenDocumentAdress, value);
		}

		[Ordinal(26)] 
		[RED("onMailThumbnailWidgetsUpdateListener")] 
		public CUInt32 OnMailThumbnailWidgetsUpdateListener
		{
			get => GetProperty(ref _onMailThumbnailWidgetsUpdateListener);
			set => SetProperty(ref _onMailThumbnailWidgetsUpdateListener, value);
		}

		[Ordinal(27)] 
		[RED("onFileThumbnailWidgetsUpdateListener")] 
		public CUInt32 OnFileThumbnailWidgetsUpdateListener
		{
			get => GetProperty(ref _onFileThumbnailWidgetsUpdateListener);
			set => SetProperty(ref _onFileThumbnailWidgetsUpdateListener, value);
		}

		[Ordinal(28)] 
		[RED("onMailWidgetsUpdateListener")] 
		public CUInt32 OnMailWidgetsUpdateListener
		{
			get => GetProperty(ref _onMailWidgetsUpdateListener);
			set => SetProperty(ref _onMailWidgetsUpdateListener, value);
		}

		[Ordinal(29)] 
		[RED("onFileWidgetsUpdateListener")] 
		public CUInt32 OnFileWidgetsUpdateListener
		{
			get => GetProperty(ref _onFileWidgetsUpdateListener);
			set => SetProperty(ref _onFileWidgetsUpdateListener, value);
		}

		[Ordinal(30)] 
		[RED("onMenuButtonWidgetsUpdateListener")] 
		public CUInt32 OnMenuButtonWidgetsUpdateListener
		{
			get => GetProperty(ref _onMenuButtonWidgetsUpdateListener);
			set => SetProperty(ref _onMenuButtonWidgetsUpdateListener, value);
		}

		[Ordinal(31)] 
		[RED("onMainMenuButtonWidgetsUpdateListener")] 
		public CUInt32 OnMainMenuButtonWidgetsUpdateListener
		{
			get => GetProperty(ref _onMainMenuButtonWidgetsUpdateListener);
			set => SetProperty(ref _onMainMenuButtonWidgetsUpdateListener, value);
		}

		[Ordinal(32)] 
		[RED("onBannerWidgetsUpdateListener")] 
		public CUInt32 OnBannerWidgetsUpdateListener
		{
			get => GetProperty(ref _onBannerWidgetsUpdateListener);
			set => SetProperty(ref _onBannerWidgetsUpdateListener, value);
		}

		[Ordinal(33)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		public ComputerInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
