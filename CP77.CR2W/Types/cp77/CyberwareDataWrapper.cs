using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberwareDataWrapper : IScriptable
	{
		[Ordinal(0)]  [RED("InventoryItem")] public InventoryItemData InventoryItem { get; set; }
		[Ordinal(1)]  [RED("IsVendor")] public CBool IsVendor { get; set; }
		[Ordinal(2)]  [RED("PlayerMoney")] public CInt32 PlayerMoney { get; set; }

		public CyberwareDataWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
