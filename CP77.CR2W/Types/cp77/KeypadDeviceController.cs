using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KeypadDeviceController : DeviceWidgetControllerBase
	{
		[Ordinal(0)]  [RED("targetWidgetRef")] public inkWidgetReference TargetWidgetRef { get; set; }
		[Ordinal(1)]  [RED("displayNameWidget")] public inkTextWidgetReference DisplayNameWidget { get; set; }
		[Ordinal(2)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)]  [RED("targetWidget")] public wCHandle<inkWidget> TargetWidget { get; set; }
		[Ordinal(4)]  [RED("backgroundTextureRef")] public inkImageWidgetReference BackgroundTextureRef { get; set; }
		[Ordinal(5)]  [RED("statusNameWidget")] public inkTextWidgetReference StatusNameWidget { get; set; }
		[Ordinal(6)]  [RED("actionsListWidget")] public inkWidgetReference ActionsListWidget { get; set; }
		[Ordinal(7)]  [RED("actionWidgetsData")] public CArray<SActionWidgetPackage> ActionWidgetsData { get; set; }
		[Ordinal(8)]  [RED("actionData")] public CHandle<ResolveActionData> ActionData { get; set; }
		[Ordinal(9)]  [RED("enteredPasswordWidget")] public wCHandle<inkTextWidget> EnteredPasswordWidget { get; set; }
		[Ordinal(10)]  [RED("passwordStatusWidget")] public wCHandle<inkTextWidget> PasswordStatusWidget { get; set; }
		[Ordinal(11)]  [RED("actionButton")] public wCHandle<inkWidget> ActionButton { get; set; }
		[Ordinal(12)]  [RED("ActionText")] public wCHandle<inkTextWidget> ActionText { get; set; }
		[Ordinal(13)]  [RED("passwordsList")] public CArray<CName> PasswordsList { get; set; }
		[Ordinal(14)]  [RED("cardName")] public CString CardName { get; set; }
		[Ordinal(15)]  [RED("isPasswordKnown")] public CBool IsPasswordKnown { get; set; }
		[Ordinal(16)]  [RED("row1")] public wCHandle<inkHorizontalPanelWidget> Row1 { get; set; }
		[Ordinal(17)]  [RED("row2")] public wCHandle<inkHorizontalPanelWidget> Row2 { get; set; }
		[Ordinal(18)]  [RED("row3")] public wCHandle<inkHorizontalPanelWidget> Row3 { get; set; }
		[Ordinal(19)]  [RED("row4")] public wCHandle<inkHorizontalPanelWidget> Row4 { get; set; }

		public KeypadDeviceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
