using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AbilityData : CVariable
	{
		[Ordinal(0)] [RED("Empty")] public CBool Empty { get; set; }
		[Ordinal(1)] [RED("ID")] public gameItemID ID { get; set; }
		[Ordinal(2)] [RED("Name")] public CString Name { get; set; }
		[Ordinal(3)] [RED("IconPath")] public CString IconPath { get; set; }
		[Ordinal(4)] [RED("CategoryName")] public CString CategoryName { get; set; }
		[Ordinal(5)] [RED("Description")] public CString Description { get; set; }
		[Ordinal(6)] [RED("EquipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(7)] [RED("IsEquipped")] public CBool IsEquipped { get; set; }
		[Ordinal(8)] [RED("GameItemData")] public CHandle<gameItemData> GameItemData { get; set; }
		[Ordinal(9)] [RED("AssignedIndex")] public CInt32 AssignedIndex { get; set; }

		public AbilityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
