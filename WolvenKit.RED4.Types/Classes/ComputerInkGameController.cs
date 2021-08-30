using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerInkGameController : DeviceInkGameControllerBase
	{
		private TweakDBID _layoutID;
		private CName _currentLayoutLibraryID;
		private CWeakHandle<inkWidget> _mainLayout;
		private CBool _devicesMenuInitialized;
		private CBool _devicesMenuSpawned;
		private CBool _devicesMenuSpawnRequested;
		private CBool _menuInitialized;
		private CWeakHandle<inkVideoWidget> _mainDisplayWidget;
		private CEnum<EDocumentType> _forceOpenDocumentType;
		private SDocumentAdress _forceOpenDocumentAdress;
		private CHandle<redCallbackObject> _onMailThumbnailWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onFileThumbnailWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onMailWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onFileWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onMenuButtonWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onMainMenuButtonWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onBannerWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;

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
		public CWeakHandle<inkWidget> MainLayout
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
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
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
		public CHandle<redCallbackObject> OnMailThumbnailWidgetsUpdateListener
		{
			get => GetProperty(ref _onMailThumbnailWidgetsUpdateListener);
			set => SetProperty(ref _onMailThumbnailWidgetsUpdateListener, value);
		}

		[Ordinal(27)] 
		[RED("onFileThumbnailWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnFileThumbnailWidgetsUpdateListener
		{
			get => GetProperty(ref _onFileThumbnailWidgetsUpdateListener);
			set => SetProperty(ref _onFileThumbnailWidgetsUpdateListener, value);
		}

		[Ordinal(28)] 
		[RED("onMailWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnMailWidgetsUpdateListener
		{
			get => GetProperty(ref _onMailWidgetsUpdateListener);
			set => SetProperty(ref _onMailWidgetsUpdateListener, value);
		}

		[Ordinal(29)] 
		[RED("onFileWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnFileWidgetsUpdateListener
		{
			get => GetProperty(ref _onFileWidgetsUpdateListener);
			set => SetProperty(ref _onFileWidgetsUpdateListener, value);
		}

		[Ordinal(30)] 
		[RED("onMenuButtonWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnMenuButtonWidgetsUpdateListener
		{
			get => GetProperty(ref _onMenuButtonWidgetsUpdateListener);
			set => SetProperty(ref _onMenuButtonWidgetsUpdateListener, value);
		}

		[Ordinal(31)] 
		[RED("onMainMenuButtonWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnMainMenuButtonWidgetsUpdateListener
		{
			get => GetProperty(ref _onMainMenuButtonWidgetsUpdateListener);
			set => SetProperty(ref _onMainMenuButtonWidgetsUpdateListener, value);
		}

		[Ordinal(32)] 
		[RED("onBannerWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnBannerWidgetsUpdateListener
		{
			get => GetProperty(ref _onBannerWidgetsUpdateListener);
			set => SetProperty(ref _onBannerWidgetsUpdateListener, value);
		}

		[Ordinal(33)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		public ComputerInkGameController()
		{
			_forceOpenDocumentType = new() { Value = Enums.EDocumentType.Invalid };
		}
	}
}
