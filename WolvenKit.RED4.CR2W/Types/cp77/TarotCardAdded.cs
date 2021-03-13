using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardAdded : redEvent
	{
		[Ordinal(0)] [RED("imagePart")] public CName ImagePart { get; set; }
		[Ordinal(1)] [RED("cardName")] public CString CardName { get; set; }

		public TarotCardAdded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
