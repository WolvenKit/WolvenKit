using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiGridCell : CVariable
	{
		[Ordinal(0)]  [RED("currentTrap")] public CHandle<gamedataMiniGame_Trap_Record> CurrentTrap { get; set; }
		[Ordinal(1)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(2)]  [RED("rarityValue")] public CInt32 RarityValue { get; set; }

		public gameuiGridCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
