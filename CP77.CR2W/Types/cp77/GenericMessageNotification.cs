using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotification : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(1)]  [RED("message")] public inkTextWidgetReference Message { get; set; }
		[Ordinal(2)]  [RED("buttonConfirm")] public inkWidgetReference ButtonConfirm { get; set; }
		[Ordinal(3)]  [RED("buttonCancel")] public inkWidgetReference ButtonCancel { get; set; }
		[Ordinal(4)]  [RED("buttonOk")] public inkWidgetReference ButtonOk { get; set; }
		[Ordinal(5)]  [RED("buttonYes")] public inkWidgetReference ButtonYes { get; set; }
		[Ordinal(6)]  [RED("buttonNo")] public inkWidgetReference ButtonNo { get; set; }
		[Ordinal(7)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(8)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(9)]  [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(10)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(11)]  [RED("data")] public CHandle<GenericMessageNotificationData> Data { get; set; }
		[Ordinal(12)]  [RED("isNegativeHovered")] public CBool IsNegativeHovered { get; set; }
		[Ordinal(13)]  [RED("isPositiveHovered")] public CBool IsPositiveHovered { get; set; }
		[Ordinal(14)]  [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(15)]  [RED("closeData")] public CHandle<GenericMessageNotificationCloseData> CloseData { get; set; }

		public GenericMessageNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
