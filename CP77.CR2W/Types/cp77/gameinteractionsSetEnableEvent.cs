using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsSetEnableEvent : redEvent
	{
		[Ordinal(0)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)]  [RED("layer")] public CName Layer { get; set; }
		[Ordinal(2)]  [RED("linkedLayers")] public CName LinkedLayers { get; set; }

		public gameinteractionsSetEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
