using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractionsInputView : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("AllItemsNum")] public CInt32 AllItemsNum { get; set; }
		[Ordinal(1)]  [RED("BotArrowRef")] public inkWidgetReference BotArrowRef { get; set; }
		[Ordinal(2)]  [RED("CurrentNum")] public CInt32 CurrentNum { get; set; }
		[Ordinal(3)]  [RED("DefaultInputPartName")] public CName DefaultInputPartName { get; set; }
		[Ordinal(4)]  [RED("HasAbove")] public CBool HasAbove { get; set; }
		[Ordinal(5)]  [RED("HasBelow")] public CBool HasBelow { get; set; }
		[Ordinal(6)]  [RED("InputImage")] public inkImageWidgetReference InputImage { get; set; }
		[Ordinal(7)]  [RED("ShowArrows")] public CBool ShowArrows { get; set; }
		[Ordinal(8)]  [RED("TopArrowRef")] public inkWidgetReference TopArrowRef { get; set; }

		public InteractionsInputView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
