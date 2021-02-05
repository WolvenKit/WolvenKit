using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BackdoorDataStreamController : BackdoorInkGameController
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
		[Ordinal(14)]  [RED("thumbnailWidgetsData")] public CArray<SThumbnailWidgetPackage> ThumbnailWidgetsData { get; set; }
		[Ordinal(15)]  [RED("onThumbnailWidgetsUpdateListener")] public CUInt32 OnThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(16)]  [RED("IdleGroup")] public inkWidgetReference IdleGroup { get; set; }
		[Ordinal(17)]  [RED("ConnectedGroup")] public inkWidgetReference ConnectedGroup { get; set; }
		[Ordinal(18)]  [RED("IntroAnimationName")] public CName IntroAnimationName { get; set; }
		[Ordinal(19)]  [RED("IdleAnimationName")] public CName IdleAnimationName { get; set; }
		[Ordinal(20)]  [RED("GlitchAnimationName")] public CName GlitchAnimationName { get; set; }
		[Ordinal(21)]  [RED("RunningAnimation")] public CHandle<inkanimProxy> RunningAnimation { get; set; }
		[Ordinal(22)]  [RED("onGlitchingListener")] public CUInt32 OnGlitchingListener { get; set; }
		[Ordinal(23)]  [RED("onIsInDefaultStateListener")] public CUInt32 OnIsInDefaultStateListener { get; set; }
		[Ordinal(24)]  [RED("onShutdownModuleListener")] public CUInt32 OnShutdownModuleListener { get; set; }
		[Ordinal(25)]  [RED("onBootModuleListener")] public CUInt32 OnBootModuleListener { get; set; }
		[Ordinal(26)]  [RED("idleGroup")] public inkWidgetReference IdleGroup { get; set; }
		[Ordinal(27)]  [RED("idleVPanelC1")] public inkWidgetReference IdleVPanelC1 { get; set; }
		[Ordinal(28)]  [RED("idleVPanelC2")] public inkWidgetReference IdleVPanelC2 { get; set; }
		[Ordinal(29)]  [RED("idleVPanelC3")] public inkWidgetReference IdleVPanelC3 { get; set; }
		[Ordinal(30)]  [RED("idleVPanelC4")] public inkWidgetReference IdleVPanelC4 { get; set; }
		[Ordinal(31)]  [RED("hackedGroup")] public inkWidgetReference HackedGroup { get; set; }
		[Ordinal(32)]  [RED("idleCanvas1")] public inkWidgetReference IdleCanvas1 { get; set; }
		[Ordinal(33)]  [RED("idleCanvas2")] public inkWidgetReference IdleCanvas2 { get; set; }
		[Ordinal(34)]  [RED("idleCanvas3")] public inkWidgetReference IdleCanvas3 { get; set; }
		[Ordinal(35)]  [RED("idleCanvas4")] public inkWidgetReference IdleCanvas4 { get; set; }
		[Ordinal(36)]  [RED("canvasC1")] public inkWidgetReference CanvasC1 { get; set; }
		[Ordinal(37)]  [RED("canvasC2")] public inkWidgetReference CanvasC2 { get; set; }
		[Ordinal(38)]  [RED("canvasC3")] public inkWidgetReference CanvasC3 { get; set; }
		[Ordinal(39)]  [RED("canvasC4")] public inkWidgetReference CanvasC4 { get; set; }

		public BackdoorDataStreamController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
