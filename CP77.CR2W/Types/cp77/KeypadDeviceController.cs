using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KeypadDeviceController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] [RED("enteredPasswordWidget")] public wCHandle<inkTextWidget> EnteredPasswordWidget { get; set; }
		[Ordinal(11)] [RED("passwordStatusWidget")] public wCHandle<inkTextWidget> PasswordStatusWidget { get; set; }
		[Ordinal(12)] [RED("actionButton")] public wCHandle<inkWidget> ActionButton { get; set; }
		[Ordinal(13)] [RED("ActionText")] public wCHandle<inkTextWidget> ActionText { get; set; }
		[Ordinal(14)] [RED("passwordsList")] public CArray<CName> PasswordsList { get; set; }
		[Ordinal(15)] [RED("cardName")] public CString CardName { get; set; }
		[Ordinal(16)] [RED("isPasswordKnown")] public CBool IsPasswordKnown { get; set; }
		[Ordinal(17)] [RED("row1")] public wCHandle<inkHorizontalPanelWidget> Row1 { get; set; }
		[Ordinal(18)] [RED("row2")] public wCHandle<inkHorizontalPanelWidget> Row2 { get; set; }
		[Ordinal(19)] [RED("row3")] public wCHandle<inkHorizontalPanelWidget> Row3 { get; set; }
		[Ordinal(20)] [RED("row4")] public wCHandle<inkHorizontalPanelWidget> Row4 { get; set; }

		public KeypadDeviceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
