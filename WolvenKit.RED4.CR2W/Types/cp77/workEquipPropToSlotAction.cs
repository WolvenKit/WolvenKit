using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workEquipPropToSlotAction : workIWorkspotItemAction
	{
		[Ordinal(0)] [RED("itemId")] public CName ItemId { get; set; }
		[Ordinal(1)] [RED("itemSlot")] public TweakDBID ItemSlot { get; set; }
		[Ordinal(2)] [RED("attachMethod")] public CEnum<workPropAttachMethod> AttachMethod { get; set; }
		[Ordinal(3)] [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(4)] [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }

		public workEquipPropToSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
