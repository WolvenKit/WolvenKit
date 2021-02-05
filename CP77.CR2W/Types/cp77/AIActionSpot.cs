using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIActionSpot : AISmartSpot
	{
		[Ordinal(0)]  [RED("ActorBodytypeE3")] public CEnum<AISocketsForRig> ActorBodytypeE3 { get; set; }
		[Ordinal(1)]  [RED("resource")] public raRef<workWorkspotResource> Resource { get; set; }
		[Ordinal(2)]  [RED("masterNodeRef")] public NodeRef MasterNodeRef { get; set; }
		[Ordinal(3)]  [RED("enabledWhenMasterOccupied")] public CBool EnabledWhenMasterOccupied { get; set; }
		[Ordinal(4)]  [RED("snapToGround")] public CBool SnapToGround { get; set; }
		[Ordinal(5)]  [RED("useClippingSpace")] public CBool UseClippingSpace { get; set; }
		[Ordinal(6)]  [RED("clippingSpaceOrientation")] public CFloat ClippingSpaceOrientation { get; set; }
		[Ordinal(7)]  [RED("clippingSpaceRange")] public CFloat ClippingSpaceRange { get; set; }

		public AIActionSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
