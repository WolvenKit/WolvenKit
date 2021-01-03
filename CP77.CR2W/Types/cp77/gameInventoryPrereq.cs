using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameInventoryPrereq : gameIComparisonPrereq
	{
		[Ordinal(0)]  [RED("amount")] public CUInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("itemID")] public gameItemID ItemID { get; set; }

		public gameInventoryPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
