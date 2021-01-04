using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSLoadout : CVariable
	{
		[Ordinal(0)]  [RED("equipAreas")] public CArray<gameSEquipArea> EquipAreas { get; set; }
		[Ordinal(1)]  [RED("equipmentSets")] public CArray<gameSEquipmentSet> EquipmentSets { get; set; }

		public gameSLoadout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
