using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotification : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(3)] [RED("message")] public inkTextWidgetReference Message { get; set; }
		[Ordinal(4)] [RED("buttonConfirm")] public inkWidgetReference ButtonConfirm { get; set; }
		[Ordinal(5)] [RED("buttonCancel")] public inkWidgetReference ButtonCancel { get; set; }
		[Ordinal(6)] [RED("buttonOk")] public inkWidgetReference ButtonOk { get; set; }
		[Ordinal(7)] [RED("buttonYes")] public inkWidgetReference ButtonYes { get; set; }
		[Ordinal(8)] [RED("buttonNo")] public inkWidgetReference ButtonNo { get; set; }
		[Ordinal(9)] [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(10)] [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(11)] [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(12)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(13)] [RED("data")] public CHandle<GenericMessageNotificationData> Data { get; set; }
		[Ordinal(14)] [RED("isNegativeHovered")] public CBool IsNegativeHovered { get; set; }
		[Ordinal(15)] [RED("isPositiveHovered")] public CBool IsPositiveHovered { get; set; }
		[Ordinal(16)] [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(17)] [RED("closeData")] public CHandle<GenericMessageNotificationCloseData> CloseData { get; set; }

		public GenericMessageNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
