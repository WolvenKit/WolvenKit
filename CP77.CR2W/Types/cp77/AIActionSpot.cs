using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIActionSpot : AISmartSpot
	{
		[Ordinal(0)]  [RED("ActorBodytypeE3")] public CEnum<AISocketsForRig> ActorBodytypeE3 { get; set; }
		[Ordinal(1)]  [RED("clippingSpaceOrientation")] public CFloat ClippingSpaceOrientation { get; set; }
		[Ordinal(2)]  [RED("clippingSpaceRange")] public CFloat ClippingSpaceRange { get; set; }
		[Ordinal(3)]  [RED("enabledWhenMasterOccupied")] public CBool EnabledWhenMasterOccupied { get; set; }
		[Ordinal(4)]  [RED("masterNodeRef")] public NodeRef MasterNodeRef { get; set; }
		[Ordinal(5)]  [RED("resource")] public raRef<workWorkspotResource> Resource { get; set; }
		[Ordinal(6)]  [RED("snapToGround")] public CBool SnapToGround { get; set; }
		[Ordinal(7)]  [RED("useClippingSpace")] public CBool UseClippingSpace { get; set; }

		public AIActionSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
