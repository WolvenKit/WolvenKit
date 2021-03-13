using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnMarker : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<scnMarkerType> Type { get; set; }
		[Ordinal(1)] [RED("localMarkerId")] public CName LocalMarkerId { get; set; }
		[Ordinal(2)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(3)] [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(4)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(5)] [RED("isMounted")] public CBool IsMounted { get; set; }

		public scnMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
