using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnMarker : CVariable
	{
		[Ordinal(0)]  [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(1)]  [RED("isMounted")] public CBool IsMounted { get; set; }
		[Ordinal(2)]  [RED("localMarkerId")] public CName LocalMarkerId { get; set; }
		[Ordinal(3)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(4)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<scnMarkerType> Type { get; set; }

		public scnMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
