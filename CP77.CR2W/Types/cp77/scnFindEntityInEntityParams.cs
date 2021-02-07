using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInEntityParams : CVariable
	{
		[Ordinal(0)]  [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(1)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(2)]  [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(3)]  [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(4)]  [RED("forceMaxVisibility")] public CBool ForceMaxVisibility { get; set; }
		[Ordinal(5)]  [RED("ownershipTransferOptions")] public scnPropOwnershipTransferOptions OwnershipTransferOptions { get; set; }

		public scnFindEntityInEntityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
