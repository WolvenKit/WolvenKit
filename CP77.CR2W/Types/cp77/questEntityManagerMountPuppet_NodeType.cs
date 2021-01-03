using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerMountPuppet_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)]  [RED("assign")] public CBool Assign { get; set; }
		[Ordinal(1)]  [RED("childRef")] public gameEntityReference ChildRef { get; set; }
		[Ordinal(2)]  [RED("forcedCarryStyle")] public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle { get; set; }
		[Ordinal(3)]  [RED("isInstant")] public CBool IsInstant { get; set; }
		[Ordinal(4)]  [RED("isParentPlayer")] public CBool IsParentPlayer { get; set; }
		[Ordinal(5)]  [RED("parentRef")] public gameEntityReference ParentRef { get; set; }
		[Ordinal(6)]  [RED("removePitchRollRotation")] public CBool RemovePitchRollRotation { get; set; }
		[Ordinal(7)]  [RED("slotName")] public CName SlotName { get; set; }

		public questEntityManagerMountPuppet_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
