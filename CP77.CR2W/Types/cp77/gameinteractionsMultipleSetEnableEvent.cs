using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsMultipleSetEnableEvent : redEvent
	{
		[Ordinal(0)] [RED("enable", 4)] public CStatic<CBool> Enable { get; set; }
		[Ordinal(1)] [RED("layer", 4)] public CStatic<CName> Layer { get; set; }
		[Ordinal(2)] [RED("linkedLayers", 4)] public CStatic<CName> LinkedLayers { get; set; }

		public gameinteractionsMultipleSetEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
