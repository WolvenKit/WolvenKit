using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("animationManager")] public CHandle<WidgetAnimationManager> AnimationManager { get; set; }
		[Ordinal(1)]  [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(2)]  [RED("actionWidgetsData")] public CArray<SActionWidgetPackage> ActionWidgetsData { get; set; }
		[Ordinal(3)]  [RED("deviceWidgetsData")] public CArray<SDeviceWidgetPackage> DeviceWidgetsData { get; set; }
		[Ordinal(4)]  [RED("breadcrumbStack")] public CArray<SBreadcrumbElementData> BreadcrumbStack { get; set; }
		[Ordinal(5)]  [RED("cashedState")] public CEnum<EDeviceStatus> CashedState { get; set; }
		[Ordinal(6)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(7)]  [RED("hasUICameraZoom")] public CBool HasUICameraZoom { get; set; }
		[Ordinal(8)]  [RED("activeBreadcrumb")] public SBreadcrumbElementData ActiveBreadcrumb { get; set; }
		[Ordinal(9)]  [RED("onRefreshListener")] public CUInt32 OnRefreshListener { get; set; }
		[Ordinal(10)]  [RED("onActionWidgetsUpdateListener")] public CUInt32 OnActionWidgetsUpdateListener { get; set; }
		[Ordinal(11)]  [RED("onDeviceWidgetsUpdateListener")] public CUInt32 OnDeviceWidgetsUpdateListener { get; set; }
		[Ordinal(12)]  [RED("onBreadcrumbBarUpdateListener")] public CUInt32 OnBreadcrumbBarUpdateListener { get; set; }
		[Ordinal(13)]  [RED("bbCallbacksRegistered")] public CBool BbCallbacksRegistered { get; set; }
		[Ordinal(14)]  [RED("layoutID")] public TweakDBID LayoutID { get; set; }
		[Ordinal(15)]  [RED("currentLayoutLibraryID")] public CName CurrentLayoutLibraryID { get; set; }
		[Ordinal(16)]  [RED("mainLayout")] public wCHandle<inkWidget> MainLayout { get; set; }
		[Ordinal(17)]  [RED("devicesMenuInitialized")] public CBool DevicesMenuInitialized { get; set; }
		[Ordinal(18)]  [RED("devicesMenuSpawned")] public CBool DevicesMenuSpawned { get; set; }
		[Ordinal(19)]  [RED("devicesMenuSpawnRequested")] public CBool DevicesMenuSpawnRequested { get; set; }
		[Ordinal(20)]  [RED("menuInitialized")] public CBool MenuInitialized { get; set; }
		[Ordinal(21)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(22)]  [RED("forceOpenDocumentType")] public CEnum<EDocumentType> ForceOpenDocumentType { get; set; }
		[Ordinal(23)]  [RED("forceOpenDocumentAdress")] public SDocumentAdress ForceOpenDocumentAdress { get; set; }
		[Ordinal(24)]  [RED("onMailThumbnailWidgetsUpdateListener")] public CUInt32 OnMailThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(25)]  [RED("onFileThumbnailWidgetsUpdateListener")] public CUInt32 OnFileThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(26)]  [RED("onMailWidgetsUpdateListener")] public CUInt32 OnMailWidgetsUpdateListener { get; set; }
		[Ordinal(27)]  [RED("onFileWidgetsUpdateListener")] public CUInt32 OnFileWidgetsUpdateListener { get; set; }
		[Ordinal(28)]  [RED("onMenuButtonWidgetsUpdateListener")] public CUInt32 OnMenuButtonWidgetsUpdateListener { get; set; }
		[Ordinal(29)]  [RED("onMainMenuButtonWidgetsUpdateListener")] public CUInt32 OnMainMenuButtonWidgetsUpdateListener { get; set; }
		[Ordinal(30)]  [RED("onBannerWidgetsUpdateListener")] public CUInt32 OnBannerWidgetsUpdateListener { get; set; }
		[Ordinal(31)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }

		public ComputerInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
