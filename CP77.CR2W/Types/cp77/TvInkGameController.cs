using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TvInkGameController : DeviceInkGameControllerBase
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
		[Ordinal(14)]  [RED("defaultUI")] public wCHandle<inkCanvasWidget> DefaultUI { get; set; }
		[Ordinal(15)]  [RED("securedUI")] public wCHandle<inkCanvasWidget> SecuredUI { get; set; }
		[Ordinal(16)]  [RED("channellTextWidget")] public wCHandle<inkTextWidget> ChannellTextWidget { get; set; }
		[Ordinal(17)]  [RED("securedTextWidget")] public wCHandle<inkTextWidget> SecuredTextWidget { get; set; }
		[Ordinal(18)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(19)]  [RED("actionsList")] public wCHandle<inkWidget> ActionsList { get; set; }
		[Ordinal(20)]  [RED("activeChannelIDX")] public CInt32 ActiveChannelIDX { get; set; }
		[Ordinal(21)]  [RED("activeSequence")] public CArray<SequenceVideo> ActiveSequence { get; set; }
		[Ordinal(22)]  [RED("activeSequenceVideo")] public CInt32 ActiveSequenceVideo { get; set; }
		[Ordinal(23)]  [RED("globalTVChannels")] public CArray<wCHandle<inkWidget>> GlobalTVChannels { get; set; }
		[Ordinal(24)]  [RED("messegeWidget")] public wCHandle<inkTextWidget> MessegeWidget { get; set; }
		[Ordinal(25)]  [RED("backgroundWidget")] public wCHandle<inkLeafWidget> BackgroundWidget { get; set; }
		[Ordinal(26)]  [RED("previousGlobalTVChannelID")] public CInt32 PreviousGlobalTVChannelID { get; set; }
		[Ordinal(27)]  [RED("globalTVchanellsCount")] public CInt32 GlobalTVchanellsCount { get; set; }
		[Ordinal(28)]  [RED("globalTVchanellsSpawned")] public CInt32 GlobalTVchanellsSpawned { get; set; }
		[Ordinal(29)]  [RED("globalTVslot")] public wCHandle<inkWidget> GlobalTVslot { get; set; }
		[Ordinal(30)]  [RED("activeAudio")] public CName ActiveAudio { get; set; }
		[Ordinal(31)]  [RED("activeMessage")] public wCHandle<gamedataScreenMessageData_Record> ActiveMessage { get; set; }
		[Ordinal(32)]  [RED("onChangeChannelListener")] public CUInt32 OnChangeChannelListener { get; set; }
		[Ordinal(33)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }

		public TvInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
