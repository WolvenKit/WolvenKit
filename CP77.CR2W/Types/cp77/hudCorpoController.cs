using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudCorpoController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("ScrollText")] public inkTextWidgetReference ScrollText { get; set; }
		[Ordinal(8)]  [RED("ScrollTextWidget")] public inkWidgetReference ScrollTextWidget { get; set; }
		[Ordinal(9)]  [RED("root_canvas")] public inkWidgetReference Root_canvas { get; set; }
		[Ordinal(10)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(11)]  [RED("fact1ListenerId")] public CUInt32 Fact1ListenerId { get; set; }
		[Ordinal(12)]  [RED("fact2ListenerId")] public CUInt32 Fact2ListenerId { get; set; }
		[Ordinal(13)]  [RED("fact3ListenerId")] public CUInt32 Fact3ListenerId { get; set; }
		[Ordinal(14)]  [RED("fact4ListenerId")] public CUInt32 Fact4ListenerId { get; set; }
		[Ordinal(15)]  [RED("fact5ListenerId")] public CUInt32 Fact5ListenerId { get; set; }

		public hudCorpoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
