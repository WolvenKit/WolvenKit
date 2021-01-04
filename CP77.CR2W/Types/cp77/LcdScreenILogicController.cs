using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LcdScreenILogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("backgroundWidget")] public inkImageWidgetReference BackgroundWidget { get; set; }
		[Ordinal(1)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(2)]  [RED("defaultUI")] public inkWidgetReference DefaultUI { get; set; }
		[Ordinal(3)]  [RED("mainDisplayWidget")] public inkVideoWidgetReference MainDisplayWidget { get; set; }
		[Ordinal(4)]  [RED("messegeRecord")] public wCHandle<gamedataScreenMessageData_Record> MessegeRecord { get; set; }
		[Ordinal(5)]  [RED("messegeWidget")] public inkTextWidgetReference MessegeWidget { get; set; }
		[Ordinal(6)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }

		public LcdScreenILogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
