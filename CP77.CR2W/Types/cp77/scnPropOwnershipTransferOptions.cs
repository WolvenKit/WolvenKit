using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnPropOwnershipTransferOptions : CVariable
	{
		[Ordinal(0)]  [RED("dettachFromSlot")] public CBool DettachFromSlot { get; set; }
		[Ordinal(1)]  [RED("removeFromInventory")] public CBool RemoveFromInventory { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<scnPropOwnershipTransferOptionsType> Type { get; set; }

		public scnPropOwnershipTransferOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
