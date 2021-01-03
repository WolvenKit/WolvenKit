using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class KeypadDeviceController : DeviceWidgetControllerBase
	{
		[Ordinal(0)]  [RED("ActionText")] public wCHandle<inkTextWidget> ActionText { get; set; }
		[Ordinal(1)]  [RED("actionButton")] public wCHandle<inkWidget> ActionButton { get; set; }
		[Ordinal(2)]  [RED("cardName")] public CString CardName { get; set; }
		[Ordinal(3)]  [RED("enteredPasswordWidget")] public wCHandle<inkTextWidget> EnteredPasswordWidget { get; set; }
		[Ordinal(4)]  [RED("isPasswordKnown")] public CBool IsPasswordKnown { get; set; }
		[Ordinal(5)]  [RED("passwordStatusWidget")] public wCHandle<inkTextWidget> PasswordStatusWidget { get; set; }
		[Ordinal(6)]  [RED("passwordsList")] public CArray<CName> PasswordsList { get; set; }
		[Ordinal(7)]  [RED("row1")] public wCHandle<inkHorizontalPanelWidget> Row1 { get; set; }
		[Ordinal(8)]  [RED("row2")] public wCHandle<inkHorizontalPanelWidget> Row2 { get; set; }
		[Ordinal(9)]  [RED("row3")] public wCHandle<inkHorizontalPanelWidget> Row3 { get; set; }
		[Ordinal(10)]  [RED("row4")] public wCHandle<inkHorizontalPanelWidget> Row4 { get; set; }

		public KeypadDeviceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
