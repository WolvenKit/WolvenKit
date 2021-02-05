using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsMultipleSetEnableEvent : redEvent
	{
		[Ordinal(0)]  [RED("enable", 4)] public CStatic<CBool> Enable { get; set; }
		[Ordinal(1)]  [RED("layer", lignas(8) StaticArray<CNam, 4)] public alignas(8) StaticArray<CName> Layer { get; set; }
		[Ordinal(2)]  [RED("linkedLayers", lignas(8) StaticArray<CNam, 4)] public alignas(8) StaticArray<CName> LinkedLayers { get; set; }

		public gameinteractionsMultipleSetEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
