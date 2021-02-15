using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeItemUnequipRequest : IScriptable
	{
		[Ordinal(0)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(1)] [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(2)] [RED("instant")] public CBool Instant { get; set; }

		public gamestateMachineparameterTypeItemUnequipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
