using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPropOwnershipTransferOptions : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<scnPropOwnershipTransferOptionsType> Type { get; set; }
		[Ordinal(1)] [RED("dettachFromSlot")] public CBool DettachFromSlot { get; set; }
		[Ordinal(2)] [RED("removeFromInventory")] public CBool RemoveFromInventory { get; set; }

		public scnPropOwnershipTransferOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
