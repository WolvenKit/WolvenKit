using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TarotCardAdded : redEvent
	{
		[Ordinal(0)]  [RED("cardName")] public CString CardName { get; set; }
		[Ordinal(1)]  [RED("imagePart")] public CName ImagePart { get; set; }

		public TarotCardAdded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
