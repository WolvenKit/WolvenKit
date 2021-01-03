using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementData : CVariable
	{
		[Ordinal(0)]  [RED("attachementComponentName")] public CName AttachementComponentName { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(2)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(3)]  [RED("slotComponentName")] public CName SlotComponentName { get; set; }
		[Ordinal(4)]  [RED("slotName")] public CName SlotName { get; set; }

		public EntityAttachementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
