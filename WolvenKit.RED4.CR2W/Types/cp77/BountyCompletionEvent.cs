using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BountyCompletionEvent : redEvent
	{
		[Ordinal(0)] [RED("streetCredAwarded")] public CInt32 StreetCredAwarded { get; set; }
		[Ordinal(1)] [RED("moneyAwarded")] public CInt32 MoneyAwarded { get; set; }

		public BountyCompletionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
