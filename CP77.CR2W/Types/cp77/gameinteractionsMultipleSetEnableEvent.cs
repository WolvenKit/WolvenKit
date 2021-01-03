using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsMultipleSetEnableEvent : redEvent
	{
		[Ordinal(0)]  [RED("enable")] public CStatic<4,Bool> Enable { get; set; }
		[Ordinal(1)]  [RED("layer")] public CStatic<4,CName> Layer { get; set; }
		[Ordinal(2)]  [RED("linkedLayers")] public CStatic<4,CName> LinkedLayers { get; set; }

		public gameinteractionsMultipleSetEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
