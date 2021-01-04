using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsSetChoicesEvent : redEvent
	{
		[Ordinal(0)]  [RED("choices")] public CArray<gameinteractionsChoice> Choices { get; set; }
		[Ordinal(1)]  [RED("layer")] public CName Layer { get; set; }

		public gameinteractionsSetChoicesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
