using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponMachineInkGameController : VendingMachineInkGameController
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
		[Ordinal(14)]  [RED("ActionsPanel")] public inkHorizontalPanelWidgetReference ActionsPanel { get; set; }
		[Ordinal(15)]  [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(16)]  [RED("noMoneyPanel")] public inkCompoundWidgetReference NoMoneyPanel { get; set; }
		[Ordinal(17)]  [RED("soldOutPanel")] public inkCompoundWidgetReference SoldOutPanel { get; set; }
		[Ordinal(18)]  [RED("state")] public CEnum<PaymentStatus> State { get; set; }
		[Ordinal(19)]  [RED("soldOut")] public CBool SoldOut { get; set; }
		[Ordinal(20)]  [RED("onUpdateStatusListener")] public CUInt32 OnUpdateStatusListener { get; set; }
		[Ordinal(21)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(22)]  [RED("onSoldOutListener")] public CUInt32 OnSoldOutListener { get; set; }
		[Ordinal(23)]  [RED("buttonRef")] public CHandle<WeaponVendorActionWidgetController> ButtonRef { get; set; }

		public WeaponMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
